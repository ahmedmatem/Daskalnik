using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Models
{
    /// <summary>
    /// Many-to-many mapping table for Group and Topic.
    /// </summary>
    [Comment("Many-to-many mapping table for Group and Topic.")]
    public class GroupTopic
    {
        [Comment("Primary key.")]
        public string GroupId { get; set; } = string.Empty;

        [Comment("Primary key.")]
        public string TopicId { get; set; } = string.Empty;

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; } = null!;

        [ForeignKey("GroupId")]
        public Group Group { get; set; } = null!;
    }
}
