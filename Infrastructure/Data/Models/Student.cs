using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Models
{
    public class Student : DataModel
    {
        [Required]
        [MaxLength(StudentFullNameMaxLength)]
        [Comment("Student full name.")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of school the student attends.")]
        public string SchoolId { get; set; } = string.Empty;

        [ForeignKey("SchoolId")]
        public School School { get; set; } = null!;

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
