using System.ComponentModel.DataAnnotations;

namespace Core.Models.Teachers
{
    public class TeacherDropdownViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}
