﻿using Core.Contracts;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class TopicResourceService : ITopicResourceService
    {
        private readonly IRepository repository;
        private readonly IResourceService resourceService;

        public TopicResourceService(
            IRepository _repository,
            IResourceService _resourceService)
        {
            repository = _repository;
            resourceService = _resourceService;
        }

        public async Task DeleteAsync(string topicId, string resourceId)
        {
            var topicResource = await repository.All<TopicResource>()
                .Where(tr => tr.ResourceId == resourceId && tr.TopicId == topicId)
                .SingleOrDefaultAsync();
            if(topicResource != null)
            {
                repository.Delete<TopicResource>(topicResource);
                await repository.SaveChangesAsync<TopicResource>();
            }
        }
    }
}
