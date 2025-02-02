using Core.Models.Exam;
using Core.Models.GroupTopic;
using Core.Models.Student;
using Core.Models.Topic;
using Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Group
{
    /// <summary>
    /// Group service model for Teacher role.
    /// </summary>
    public class GroupServiceModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Title of the group.
        /// </summary>
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Short name of the group.
        /// </summary>
        [Display(Name = "Кратко име")]
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// Group short description.
        /// </summary>
        [Display(Name = "Кратко описание")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Path reference to group icon.
        /// </summary>
        [Display(Name = "Картинка")]
        public string IconUrl { get; set; } = string.Empty;

        public string SchoolId { get; set; } = string.Empty;

        public string TeacherId { get; set; } = string.Empty;

        /// <summary>
        /// Contains all topics in the group.
        /// </summary>
        public IEnumerable<TopicServiceModel> Topics { get; set; } = new List<TopicServiceModel>();

        /// <summary>
        /// Contains all students in the group.
        /// </summary>
        public GroupStudentsModel GroupStudents { get; set; } = null!;

        /// <summary>
        /// Contains all students in the group.
        /// </summary>
        public IEnumerable<StudentLinkServiceModel> Students { get; set; } = new List<StudentLinkServiceModel>();

        /// <summary>
        /// Contains all exams in the group.
        /// </summary>
        public IEnumerable<ExamServiceModel> Exams { get; set; } = new List<ExamServiceModel>();
    }
}
