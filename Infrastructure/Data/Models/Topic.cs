namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Infrastructure.Data.Abstracts;
    using static Infrastructure.Constants.DataConstants;

    public class Topic : DataModel
    {
        [Required]
        [MaxLength(TopicNameMaxLength)]
        [Comment("Topic name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(TopicDescriptionMaxLength)]
        [Comment("Topic description.")]
        public string Description { get; set; } = string.Empty;

        [Comment("Topic contents items separated each in a new line.")]
        public string Contents { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of the creator of the topic.")]
        public string CreatorId { get; set; } = string.Empty;

        // Navigation properties

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<TopicResource> Resources { get; set; } = new List<TopicResource>();
    }
}
