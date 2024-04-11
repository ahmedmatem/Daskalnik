using Core.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.GroupStudent
{
    public class GroupStudentSelectFormServiceModel
    {

        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the group.
        /// </summary>
        [Display(Name = "Име")]
        public string GroupName { get; set; } = string.Empty;

        /// <summary>
        /// Contains all students belonging to school could be added to the group.
        /// It does not contain already added students in the group.
        /// </summary>
        public IList<CheckBoxModel> StudentsListToAdd { get; set; }
            = new List<CheckBoxModel>();
    }
}
