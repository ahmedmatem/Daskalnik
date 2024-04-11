using Core.Models.Student;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.GroupTopic
{
    public class GroupStudentsModel
    {
        /// <summary>
        /// Unique identifier of group the student belongs to
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// The list of students belongs to the group.
        /// </summary>
        [Display(Name = "ученици")]
        public IEnumerable<StudentListItemInGroupServiceModel> Students { get; set; } 
            = new List<StudentListItemInGroupServiceModel>();
    }
}
