namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Infrastructure.Data.Abstracts;
    using static Infrastructure.Constants.DataConstants;

    public class Teacher : PersonModel
    {
        [Required]
        [MaxLength(TeacherFullNameMaxLength)]
        [Comment("Teacher full name.")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of school the teacher attends.")]
        public string SchoolId { get; set; } = string.Empty;

        // Navigation properties
        public School School { get; set; } = null!;

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
