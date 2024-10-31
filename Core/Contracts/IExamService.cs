namespace Core.Contracts
{
    using Core.Models.Exam;

    public interface IExamService
    {
        Task CreateAsync(CreateExamServiceModel model);

        Task<IEnumerable<ExamListItemServiceModel>> GetAllExamsByCreatorAsync(string id);
    }
}
