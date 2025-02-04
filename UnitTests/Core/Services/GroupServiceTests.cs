using Core.Contracts;
using Core.Models.Group;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace UnitTests.Core.Services
{
    [TestFixture]
    public class GroupServiceTests
    {
        private IRepository repository;
        private ApplicationDbContext dbContext;

        private IGroupService groupService;

        private ILogger<GroupService> logger;
        private ITopicService topicService;
        private IResourceService resourceService;
        private ITopicResourceService topicResourceService;

        [SetUp]
        public void TestsSetup()
        {
            var dbcontextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase<ApplicationDbContext>("DaskalnikDB")
                .Options;

            dbContext = new ApplicationDbContext(dbcontextOptions);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);

            logger = new Mock<ILogger<GroupService>>().Object;
            topicService = new Mock<ITopicService>().Object;
            resourceService = new Mock<IResourceService>().Object;
            topicResourceService = new Mock<ITopicResourceService>().Object;

            groupService = new GroupService(
                logger,
                repository,
                topicService,
                resourceService,
                topicResourceService);
        }

        [Test]
        public async Task TestAddAsync()
        {
            GroupFormServiceModel model = new GroupFormServiceModel();

            await groupService.AddAsync(model);
            var groups = await repository
                .All<Group>()
                .ToListAsync();

            Assert.That(groups, Is.Not.Null);
            Assert.That(groups.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task TestAddStudentsInGroupAsync()
        {
            string groupId = "group-id";
            string[] studentIds = new string[]
            {
                "student-id-1", "student-id-2", "student-id-3"
            };

            await repository.AddAsync(new Group() { Id = groupId });
            await repository.SaveChangesAsync<Group>();

            await repository.AddRangeAsync<Student>(new List<Student>()
            {
                new Student(){ Id = studentIds[0]},
                new Student(){ Id = studentIds[1]},
                new Student(){ Id = studentIds[2]},
            });
            await repository.SaveChangesAsync<Student>();

            await groupService.AddStudentsInGroupAsync(groupId, studentIds);

            var studentsInGroup = await repository
                .AllReadOnly<GroupStudent>()
                .Where(gs => gs.GroupId == groupId)
                .ToListAsync();

            Assert.That(studentsInGroup, Is.Not.Null);
            Assert.That(studentsInGroup.Count, Is.EqualTo(3));
            Assert.That(studentsInGroup.All(s => studentIds.Contains(s.StudentId)), Is.True);
        }

        [Test]
        public async Task TestAddTopicsInGroupAsync()
        {
            string groupId = "group-id";
            string[] topicIds = new string[]
            {
                "topic-id-1", "topic-id-2", "topic-id-3"
            };

            await repository.AddAsync(new Group() { Id = groupId });
            await repository.SaveChangesAsync<Group>();

            await repository.AddRangeAsync<Topic>(new List<Topic>()
            {
                new Topic(){ Id = topicIds[0]},
                new Topic(){ Id = topicIds[1]},
                new Topic(){ Id = topicIds[2]},
            });
            await repository.SaveChangesAsync<Topic>();

            await groupService.AssignTopicsToGroupAsync(groupId, topicIds);

            var groupWithAddedTopics = await repository.AllReadOnly<Group>()
                .Where(g => g.Id == groupId)
                .Include(g => g.Topics)
                .SingleOrDefaultAsync();
            var addedTopics = groupWithAddedTopics?.Topics
                ?? Enumerable.Empty<Topic>();

            Assert.That(addedTopics, Is.Not.Null);
            Assert.That(addedTopics.Count, Is.EqualTo(3));
            Assert.That(addedTopics.All(t => topicIds.Contains(t.Id)), Is.True);
        }

        [Test]
        public async Task TestGetAllTeachersGroup()
        {
            var teacherId = "teacher-id";
            await repository.AddRangeAsync<Group>(new List<Group>()
            {
                new Group(){ TeacherId = teacherId},
                new Group(){ TeacherId = teacherId},
                new Group(){ TeacherId = teacherId},
            });
            await repository.SaveChangesAsync<Group>();

            var allTeacherGroups = await groupService.GetAllTeacherGroups(teacherId);

            Assert.That(allTeacherGroups, Is.Not.Null);
            Assert.That(allTeacherGroups.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task TestGetByIdAsync()
        {
            var groupId = "group-id";
            await repository.AddAsync<Group>(new Group() { Id = groupId });
            await repository.SaveChangesAsync<Group>();

            var group = await groupService.GetByIdAsync(groupId);

            Assert.That(group, Is.Not.Null);
            Assert.That(group, Has.Property("GroupTopics"));
            Assert.That(group, Has.Property("GroupStudents"));
        }

        [Test]
        public async Task TestGetGroupsCountAsync()
        {
            var currentGroupsCount = await repository.AllReadOnly<Group>().CountAsync();
            await repository.AddAsync<Group>(new Group());
            await repository.SaveChangesAsync<Group>();

            var expectedGroupsCount = currentGroupsCount + 1;

            var actualGroupsCount = await groupService.GetGroupsCountAsync();

            Assert.That(actualGroupsCount, Is.EqualTo(expectedGroupsCount));
        }

        [Test]
        public async Task TestGetGroupsCountInSchoolAsync()
        {
            string schoolId = "school-id";
            await repository.AddRangeAsync<Group>(new List<Group>()
            {
                new Group(){ SchoolId = schoolId },
                new Group(){ SchoolId = schoolId },
                new Group(){ SchoolId = schoolId },
            });
            await repository.SaveChangesAsync<Group>();

            var actualGroupsCountInSchool = await groupService
                .GetGroupsCountInSchoolAsync(schoolId);

            Assert.That(actualGroupsCountInSchool, Is.EqualTo(3));
        }

        [Test]
        public async Task TestRemoveStudentFromGroupAsync()
        {
            var studentId = "student-id";
            var groupId = "group-id";
            await repository.AddAsync(new GroupStudent() { GroupId = groupId, StudentId = studentId });
            await repository.SaveChangesAsync<GroupStudent>();

            var hasStudentInGroup = await repository
                .AllReadOnly<GroupStudent>()
                .AnyAsync(gs => gs.GroupId == groupId && gs.StudentId == studentId);

            Assert.That(hasStudentInGroup, Is.True);

            await groupService.RemoveStudentFromGroupAsync(studentId, groupId);

            hasStudentInGroup = await repository
                .AllReadOnly<GroupStudent>()
                .AnyAsync(gs => gs.GroupId == groupId && gs.StudentId == studentId);

            Assert.That(hasStudentInGroup, Is.False);
        }

        [Test]
        public async Task TestRemoveTopicFromGroupAsync()
        {
            var topicId = "topic-id";
            var groupId = "group-id";

            await repository.AddAsync(new Group()
            {
                Id = groupId,
                Topics = new List<Topic>() { new Topic() { Id = topicId } }
            });
            await repository.SaveChangesAsync<Group>();

            var group = await repository.GetByIdAsync<Group>(groupId);
            var hasTopicInGroup = group!.Topics.Any(t => t.Id == topicId);

            Assert.That(hasTopicInGroup, Is.True);

            await groupService.RemoveTopicFromGroupAsync(topicId, groupId);

            hasTopicInGroup = group!.Topics.Any(t => t.Id == topicId);

            Assert.That(hasTopicInGroup, Is.False);
        }

        [TearDown]
        public void TestsCleanUp()
        {
            dbContext.Dispose();
        }
    }
}
