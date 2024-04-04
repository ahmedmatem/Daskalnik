using Core.Models.GroupTopic;

namespace Core.Models.Group
{
    public class GroupServiceModel : GroupFormServiceModel
    {
        public GroupTopicsModel? GroupTopics { get; set; }
    }
}
