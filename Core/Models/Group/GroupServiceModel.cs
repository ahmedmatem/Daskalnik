using Core.Models.GroupTopic;
using Core.Models.Topic;
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
        /// Name of the group.
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
        public GroupTopicsModel GroupTopics { get; set; } = null!;

        /// <summary>
        /// Contains all students in the group.
        /// </summary>
        public GroupStudentsModel GroupStudents { get; set; } = null!;
    }
}
