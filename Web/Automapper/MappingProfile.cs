namespace Web.Automapper
{
    using AutoMapper;
    using Core.Models;
    using Core.Models.Group;
    using Core.Models.Resource;
    using Core.Models.Topic;
    using Core.Services;
    using Infrastructure.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ResourceServiceModel, Resource>().ReverseMap();

            CreateMap<TopicServiceModel, Topic>().ReverseMap();
            CreateMap<TopicResourceServiceModel, TopicResource>().ReverseMap();

            CreateMap<GroupServiceModel, Group>().ReverseMap();
        }
    }
}
