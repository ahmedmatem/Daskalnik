﻿using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Models
{
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

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<TopicResource> Resources { get; set; } = new List<TopicResource>();
    }
}
