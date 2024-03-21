using Core.Models.Teachers;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Admin.Schools
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
