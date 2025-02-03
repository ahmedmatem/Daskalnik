namespace Core.Contracts
{
    using Core.Models.Common;
    using Core.Models.Exam;
    using Core.Models.GroupExam;

    public interface IExamService
    {
        Task CreateAsync(CreateExamServiceModel model);

        Task<IEnumerable<ExamListItemServiceModel>> GetAllExamsByCreatorAsync(string id);

        Task<GroupExamsSelectFormModel> AllExamsNotAssignedToGroupByCreatorAsync(string creatorId, string groupId);
    }
}
