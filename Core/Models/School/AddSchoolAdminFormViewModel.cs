using Core.Models.Teacher;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.School
{
    public class AddSchoolAdminFormViewModel
    {
        public SchoolViewModel School { get; set; } = null!;

        [Display(Name = "Администратор")]
        public string TeacherId { get; set; } = string.Empty;

        public IEnumerable<TeacherDropdownViewModel> Teachers { get; set; }
            = new HashSet<TeacherDropdownViewModel>();
    }
}
