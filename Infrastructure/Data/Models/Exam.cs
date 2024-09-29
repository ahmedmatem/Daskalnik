namespace Infrastructure.Data.Models
{
    using Infrastructure.Data.Abstracts;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    using static Infrastructure.Constants.DataConstants;

    public class Exam : DataModel
    {
        [Required]
        [MaxLength(ExamNameMaxLength)]
        [Comment("Exam name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(ExamNameDescriptionMaxLength)]
        [Comment("Exam description")]
        public string Description { get; set; } = string.Empty ;

        [Required]
        [Comment("Unique identifier of the creator of the exam.")]
        public string CreatorId { get; set; } = string.Empty;

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
