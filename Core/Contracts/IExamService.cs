namespace Core.Contracts
{
    using Core.Models.Exam;

    public interface IExamService
    {
        Task CreateAsync(CreateExamServiceModel model);
    }
}
