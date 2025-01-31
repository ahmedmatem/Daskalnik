namespace Web.Automapper
{
    using AutoMapper;
    using Core.Models.Topic;
    using Infrastructure.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TopicServiceModel, Topic>().ReverseMap();
        }
    }
}
