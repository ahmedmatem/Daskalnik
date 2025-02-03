namespace Core.Models.GroupExam
{
    using System.ComponentModel.DataAnnotations;

    using Core.Models.Exam;

    public class GroupExamsModel
    {
        /// <summary>
        /// Group unique identifier
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// Exams in the group
        /// </summary>
        [Display(Name = "Изпит")]
        public IEnumerable<ExamServiceModel> Exams { get; set; } = new List<ExamServiceModel>();
    }
}
