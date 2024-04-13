using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Models
{
    public class Teacher : PersonModel
    {
        [Required]
        [MaxLength(TeacherFullNameMaxLength)]
        [Comment("Teacher full name.")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of school the teacher attends.")]
        public string SchoolId { get; set; } = string.Empty;

        public School School { get; set; } = null!;

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
