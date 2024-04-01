﻿using Core.Models.Resource;

namespace Core.Contracts
{
    public interface IResourceService
    {
        Task AddAsync(ResourceFormServiceModel model);

        Task<IEnumerable<ResourceServiceModel>> GetAllREsourcesByCreator(string creatorId);
    }
}
