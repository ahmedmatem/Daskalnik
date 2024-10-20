namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Many-to-many mapping table for Exam and Resource.
    /// </summary>
    [Comment("Many-to-many mapping table for Exam and Resource.")]
    public class ExamResource
    {
        [Required]
        [Comment("Part of primary key")]
        public string ResourceId { get; set; } = string.Empty;

        [Required]
        [Comment("Part of primary key")]
        public string ExamId { get; set; } = string.Empty;

        public Resource Resource { get; set; } = null!;

        public Exam Exam { get; set; } = null!;
    }
}
