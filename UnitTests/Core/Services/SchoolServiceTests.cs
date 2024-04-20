using Core.Contracts;
using Core.Models.School;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace UnitTests.Core.Services
{
    [TestFixture]
    public class SchoolServiceTests
    {
        private IRepository repository;
        private ILogger<SchoolService> logger;
        private ApplicationDbContext dbContext;
        private UserManager<ApplicationUser> userManager;
        private ISchoolService schoolService;

        [SetUp]
        public void TestsSetUp()
        {
            var dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("DaskalnikDB")
                .Options;
            dbContext = new ApplicationDbContext(dbOptions);
            repository = new Repository(dbContext);
            logger = new Mock<ILogger<SchoolService>>().Object;
            schoolService = new SchoolService(repository, logger, userManager);
        }

        [Test]
        public async Task TestAddAsync()
        {
            var schoolsCountBeforeAdd = await repository
                .AllReadOnly<School>()
                .CountAsync();

            await schoolService.AddAsync(new SchoolFormViewModel());
            await schoolService.AddAsync(new SchoolFormViewModel());
            await schoolService.AddAsync(new SchoolFormViewModel());

            var schoolsCoountAfterAdd = await repository
                .AllReadOnly<School>()
                .CountAsync();


            Assert.That(schoolsCoountAfterAdd, Is.EqualTo(schoolsCountBeforeAdd + 3));
        }

        [Test]
        public async Task TestBlockAsync()
        {
            string schoolId = "school-id";
            await repository.AddAsync(new School() { Id = schoolId });
            await repository.SaveChangesAsync<School>();

            var schoolToTest = await repository.GetByIdAsync<School>(schoolId);

            Assert.That(schoolToTest, Is.Not.Null);
            Assert.That(schoolToTest.IsDeleted, Is.False);

            await schoolService.BlockAsync(schoolId);

            Assert.That(schoolToTest.IsDeleted, Is.True);
        }

        [Test]
        public async Task TestUnblockAsync()
        {
            string unblockedSchoolId = "unblocked-test-school-id";
            await repository.AddAsync(new School() { Id = unblockedSchoolId, IsDeleted = true });
            await repository.SaveChangesAsync<School>();

            var schoolToTest = await repository.GetByIdAsync<School>(unblockedSchoolId);

            Assert.That(schoolToTest, Is.Not.Null);
            Assert.That(schoolToTest.IsDeleted, Is.True);

            await schoolService.UnblockAsync(unblockedSchoolId);

            Assert.That(schoolToTest.IsDeleted, Is.False);
        }

        [Test]
        public async Task GetAllBlockedAsync()
        {
            string blockedSchoolId = "blocked-school-id";
            string unblockedSchoolId = "unblocked-school-id";
            await repository.AddRangeAsync<School>(new List<School>()
            {
                new School() { Id = blockedSchoolId, IsDeleted = true },
                new School() { Id = unblockedSchoolId }
            });
            await repository.SaveChangesAsync<School>();

            var allBlocked = await schoolService.GetAllBlockedAsync();

            Assert.That(allBlocked.Any(s => s.Id == blockedSchoolId), Is.True);
            Assert.That(allBlocked.Any(s => s.Id == unblockedSchoolId), Is.False);
        }

        [Test]
        public async Task TestGetByIdAsync()
        {
            string testSchoolId = "test-school-id";
            await repository.AddAsync<School>(new School { Id = testSchoolId });
            await repository.SaveChangesAsync<School>();

            var testSchool = await schoolService.GetByIdAsync(testSchoolId);

            Assert.That(testSchool, Is.Not.Null);
            Assert.That(testSchool.Id, Is.EqualTo(testSchoolId));
        }

        [Test]
        public async Task GetSchoolsCountAsync()
        {
            var schoolsCountBeforeAdd = await schoolService.GetSchoolsCountAsync();

            await repository.AddAsync<School>(new School());
            await repository.SaveChangesAsync<School>();

            var schoolsCount = await schoolService.GetSchoolsCountAsync();

            Assert.That(schoolsCount, Is.AtLeast(1));
            Assert.That(schoolsCount, Is.EqualTo(schoolsCountBeforeAdd + 1));
        }

        [Test]
        public async Task TestSchoolExistsAsync()
        {
            string existsSchoolId = "exists-school-id";
            await repository.AddAsync<School>(new School() { Id = existsSchoolId });
            await repository.SaveChangesAsync<School>();

            var schoolExists = await schoolService.SchoolExistsAsync(existsSchoolId);

            Assert.That(schoolExists, Is.True);
        }

        [Test]
        public async Task TestUpdateAsync()
        {
            string schoolId = "update-school-id";
            await repository.AddAsync<School>(new School() 
            { 
                Id = schoolId,
                Name = "Old name",
                Type = "Old type",
                City = "Old city"
            });
            await repository.SaveChangesAsync<School>();

            var testSchool = await repository.GetByIdAsync<School>(schoolId);

            Assert.That(testSchool, Is.Not.Null);

            var model = new SchoolFormViewModel()
            {
                Id = schoolId,
                Name = "New name",
                City = "New city",
                Type = "New type",
            };

            await schoolService.UpdateAsync(model);

            var updatedSchool = await repository.GetByIdAsync<School>(schoolId);

            Assert.That(updatedSchool, Is.Not.Null);
            Assert.That(updatedSchool.Name, Is.EqualTo("New name"));
            Assert.That(updatedSchool.City, Is.EqualTo("New city"));
            Assert.That(updatedSchool.Type, Is.EqualTo("New type"));
        }

        [TearDown]
        public void TestsCleanUp()
        {
            dbContext.Dispose();
        }
    }
}
