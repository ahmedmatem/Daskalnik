using Core.Models.Topic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.GroupTopic
{
    public class GroupTopicsModel
    {
        /// <summary>
        /// Group unique identifier
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// Topics in the group
        /// </summary>
        [Display(Name = "Съдържание")]
        public IEnumerable<TopicListItemInGroupServiceModel> Topics { get; set; } 
            = new List<TopicListItemInGroupServiceModel>();
    }
}
