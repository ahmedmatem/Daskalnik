using Core.Models.Resource;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Topic
{
    public class TopicListItemInGroupServiceModel
    {
        /// <summary>
        /// Topic unique identifier.
        /// </summary>
        public string TopicId { get; set; } = string.Empty;

        /// <summary>
        /// Topic name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Unique group identifier
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// Topic contents items separated each in a new line.
        /// </summary>
        public string Contents { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the creator of the group and topics in the group.
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Collection of resources for the topic in the group.
        /// </summary>
        public IEnumerable<ResourceServiceModel> Resources { get; set; } 
            = new HashSet<ResourceServiceModel>();
    }
}
