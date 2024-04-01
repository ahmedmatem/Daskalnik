using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Models
{
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
    }
}
