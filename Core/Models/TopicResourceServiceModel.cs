namespace Core.Models
{
    using Core.Models.Resource;
    using Core.Models.Topic;

    public class TopicResourceServiceModel
    {
        public string ResourceId { get; set; } = string.Empty;

        public string TopicId { get; set; } = string.Empty;

        public TopicServiceModel Topic { get; set; } = null!;

        public ResourceServiceModel Resource { get; set; } = null!;
    }
}
