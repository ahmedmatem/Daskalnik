using Core.Models.Topic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.GroupTopic
{
    public class GroupTopicFormServiceModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the group.
        /// </summary>
        [Display(Name = "Име")]
        public string GroupName { get; set; } = string.Empty;

        /// <summary>
        /// Contains all topics belonging to a teacher could be added to its group.
        /// </summary>
        public IEnumerable<TopicListItemServiceModel> NotAddedTopics { get; set; } 
            = new HashSet<TopicListItemServiceModel>();

        /// <summary>
        /// Contains id of the topic selected from topic list.
        /// </summary>
        [Display(Name = "Моите теми")]
        public string SelectedTopicId { get; set; } = string.Empty;
    }
}
