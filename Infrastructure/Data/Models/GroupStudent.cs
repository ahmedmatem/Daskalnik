using Microsoft.EntityFrameworkCore;
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
        public string GroupId { get; set; } = string.Empty;

        [Comment("Primary key.")]
        public string StudentId { get; set; } = string.Empty;

        [ForeignKey("GroupId")]
        public Group Group { get; set; } = null!;

        [ForeignKey("StudentId")]
        public Student Student { get; set; } = null!;
    }
}
