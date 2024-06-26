﻿using Core.Models.GroupTopic;
using Core.Models.Topic;

namespace Core.Contracts
{
    public interface ITopicService
    {
        Task<TopicFormServiceModel?> GetByIdAsync(string id);

        Task<IEnumerable<TopicListItemServiceModel>> GetAllTopicsByCreatorAsync(string creatorId);

        Task AddAsync(TopicFormServiceModel model);

        Task UpdateAsync(TopicFormServiceModel model);

        Task<GroupTopicSelectFormServiceModel> GetAllCreatorTopicsExcludedFromGroupAsync(string groupId, string creatorID);
    }
}
