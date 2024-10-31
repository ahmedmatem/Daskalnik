namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Infrastructure.Data.Abstracts;
    using static Infrastructure.Constants.DataConstants;

    public class Resource : DataModel
    {
        [Required]
        [Comment("Link to resource.")]
        public string Link { get; set; } = string.Empty;

        [Required]
        [MaxLength(ResourceTextToDisplayMaxLength)]
        [Comment("Resource text to display.")]
        public string TextToDisplay { get; set; } = string.Empty;

        [Required]
        [Comment("Resource icon reference.")]
        public string IconRef { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of the creator of the resource.")]
        public string CreatorId { get; set; } = string.Empty;

        [Required]
        [Comment("Resource type (e.g. Topic, Exam, ...)")]
        public int ResourceType { get; set; }
    }
}
