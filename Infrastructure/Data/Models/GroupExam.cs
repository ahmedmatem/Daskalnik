namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Many-to-many mapping table for Group and Exam.
    /// </summary>
    [Comment("Many-to-many mapping table for Group and Exam.")]
    public class GroupExam
    {
        [Required]
        [Comment("Part of the primary key")]
        public string GroupId { get; set; } = string.Empty;

        [Required]
        [Comment("Part of the primary key")]
        public string ExamId { get; set; } = string.Empty;

        public Group Group { get; set; } = null!;

        public Exam Exam { get; set; } = null!;
    }
}
