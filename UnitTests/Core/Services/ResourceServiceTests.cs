using Core.Contracts;
using Core.Models.Resource;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace UnitTests.Core.Services
{
    [TestFixture]
    public class ResourceServiceTests
    {
        private ApplicationDbContext dbContext;
        private IRepository repository;
        private Mock<IAzureBlobService> azureBlobServiceMock;

        private IResourceService resourceService;

        [SetUp]
        public void TestsSetUp()
        {
            azureBlobServiceMock = new Mock<IAzureBlobService>();
            azureBlobServiceMock
                .Setup<string>(x => x.BlobContainerURL)
                .Returns("blob-container-fake-url");

            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("DaskalnikDB")
                .Options;
            dbContext = new ApplicationDbContext(dbContextOptions);

            repository = new Repository(dbContext);
            resourceService = new ResourceService(repository, azureBlobServiceMock.Object);
        }

        [Test]
        public async Task TestAddAsync()
        {
            await repository.AddRangeAsync<Resource>(new List<Resource>()
            {
                new Resource(),
                new Resource(),
                new Resource(),
            });
            await repository.SaveChangesAsync<Resource>();

            await resourceService.AddAsync(new ResourceFormServiceModel());

            var resourcesCount = await repository
                .AllReadOnly<Resource>()
                .CountAsync();

            Assert.That(resourcesCount, Is.EqualTo(4));
        }

        [Test]
        public async Task TestGetAllByCreator()
        {
            var creatorId = "creator-id";
            await repository.AddRangeAsync<Resource>(new List<Resource>()
            {
                new Resource(){ CreatorId = creatorId},
                new Resource(){ CreatorId = creatorId},
                new Resource(){ CreatorId = creatorId},
            });
            await repository.SaveChangesAsync<Resource>();

            var resourcesCount = await resourceService
                .GetAllByCreator(creatorId)
                .CountAsync();

            Assert.That(resourcesCount, Is.EqualTo(3));
        }

        [Test]
        public async Task TestGetAllByIds()
        {
            var ids = new List<string>() { "id-1", "id-3", "id-5" };
            await repository.AddRangeAsync<Resource>(new List<Resource>()
            {
                new Resource(){ Id = "id-1"},
                new Resource(){ Id = "id-2"},
                new Resource(){ Id = "id-3"},
                new Resource(){ Id = "id-4"},
                new Resource(){ Id = "id-5"},
                new Resource(){ Id = "id-6"},
            });
            await repository.SaveChangesAsync<Resource>();

            var resourcesCount = await resourceService
                .GetAllByIds(ids)
                .CountAsync();

            Assert.That(resourcesCount, Is.EqualTo(3));
        }

        [Test]
        public async Task TestGetByIdAsync()
        {
            var resourceId = "res-id";
            await repository.AddAsync<Resource>(new Resource() { Id = resourceId });
            await repository.SaveChangesAsync<Resource>();

            var resource = await resourceService.GetByIdAsync(resourceId);

            Assert.That(resource, Is.Not.Null);
        }

        [Test]
        public async Task TestUpdateAsync()
        {
            var resourceId = "resource-id";
            await repository.AddAsync(new Resource() 
            {
                Id = resourceId,
                Link = "resource-link"
            });
            await repository.SaveChangesAsync<Resource>();

            await resourceService.UpdateAsync(new ResourceFormServiceModel() 
                {
                    Id = resourceId,
                    Link = "new-link"
                });

            var updatedResource = await repository.GetByIdAsync<Resource>(resourceId);

            Assert.That(updatedResource!.Link, Is.EqualTo("new-link"));
        }

        [TearDown]
        public void TestsCleanUp()
        {
            dbContext.Dispose();
        }
    }
}
