using Core.Contracts;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class GroupTopicService : IGroupTopicService
    {
        private readonly IRepository repository;

        public GroupTopicService(IRepository _repository)
        {
            repository = _repository;
        }
    }
}
