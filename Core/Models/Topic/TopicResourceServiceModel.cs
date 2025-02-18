﻿namespace Core.Models.Topic
{
    using Core.Models.Resource;

    public class TopicResourceServiceModel
    {
        public string ResourceId { get; set; } = string.Empty;

        public string TopicId { get; set; } = string.Empty;

        public TopicServiceModel Topic { get; set; } = null!;

        public ResourceServiceModel Resource { get; set; } = null!;
    }
}
