namespace Core.Contracts
{
    using Core.Models.Exam;
    using Core.Models.GroupExam;

    public interface IExamService
    {
        Task CreateAsync(CreateExamServiceModel model);

        Task<IEnumerable<ExamListItemServiceModel>> GetAllExamsByCreatorAsync(string id);

        Task<IEnumerable<GroupExamsSelectFormModel>> AllExamsNotInGroupByCreatorAsync(string creatorId, string groupId);
    }
}
