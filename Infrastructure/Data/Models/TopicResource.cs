using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Models
{
    /// <summary>
    /// Many-to-many mapping table for Topic and Resource.
    /// </summary>
    [Comment("Many-to-many mapping table for Topic and Resource.")]
    public class TopicResource
    {
        [Comment("Primary key.")]
        public string ResourceId { get; set; } = string.Empty;

        [Comment("Primary key.")]
        public string TopicId { get; set; } = string.Empty;

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; } = null!;

        [ForeignKey("ResourceId")]
        public Resource Resource { get; set; } = null!;
    }
}
