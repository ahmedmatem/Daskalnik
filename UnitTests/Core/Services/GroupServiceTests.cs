using Core.Contracts;
using Core.Models.Group;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            await groupService.AddTopicsInGroupAsync(groupId, topicIds);

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

        [TearDown]
        public void TestsCleanUp()
        {
            dbContext.Dispose();
        }
    }
}
