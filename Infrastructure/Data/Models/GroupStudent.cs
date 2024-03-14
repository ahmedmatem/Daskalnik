using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Models
{
    /// <summary>
    /// Many-to-many mapping table for Group and Student.
    /// </summary>
    [Comment("Many-to-many mapping table for Group and Student.")]
    public class GroupStudent
    {
        [Comment("Primary key.")]
        [Required]
        public string GroupId { get; set; } = string.Empty;

        [Comment("Primary key.")]
        [Required]
        public string StudentId { get; set; } = string.Empty;

        public Group Group { get; set; } = null!;

        public Student Student { get; set; } = null!;
    }
}
