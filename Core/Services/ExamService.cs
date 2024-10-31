namespace Core.Services
{
    using Microsoft.EntityFrameworkCore;

    using Core.Contracts;
    using Core.Models.Exam;

    using Infrastructure.Data.DataRepository;
    using Infrastructure.Data.Models;

    public class ExamService : IExamService
    {
        private readonly IRepository repository;
        private readonly IResourceService resourceService;

        public ExamService(
            IRepository _repository,
            IResourceService _resourceService)
        {
            repository = _repository;
            resourceService = _resourceService;
        }

        public async Task CreateAsync(CreateExamServiceModel model)
        {
            var examResources = await resourceService
                .GetAllByIds(model.SelectedResources)
                .Select(sr => new ExamResource()
                {
                    ResourceId = sr.Id,
                    ExamId = model.Id
                })
                .ToListAsync();

            Exam exam = new Exam()
            {
                Title = model.Title,
                Description = model.Description ?? string.Empty,
                CreatorId = model.CreatorId,
                Resources = examResources
            };

            await repository.AddAsync<Exam>(exam);
            await repository.SaveChangesAsync<Exam>();
        }

        public async Task<IEnumerable<ExamListItemServiceModel>> GetAllExamsByCreatorAsync(string creatorId)
        {
            return await repository
                .AllReadonly<Exam>(e => e.CreatorId == creatorId && !e.IsDeleted)
                .Select(e => new ExamListItemServiceModel()
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description= e.Description,
                })
                .OrderBy(e => e.Title)
                .ToListAsync();
        }
    }
}
