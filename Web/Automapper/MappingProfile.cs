namespace Web.Automapper
{
    using AutoMapper;

    using Core.Models.Exam;
    using Core.Models.Group;
    using Core.Models.Resource;
    using Core.Models.Student;
    using Core.Models.Topic;

    using Infrastructure.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Resource, ResourceServiceModel>();
            CreateMap<Resource, ExamResourceServiceModel>();

            CreateMap<Topic, TopicServiceModel>();

            CreateMap<TopicResource, TopicResourceServiceModel>();

            CreateMap<Group, GroupServiceModel>();

            CreateMap<Student, StudentLinkServiceModel>();

            CreateMap<Exam, ExamServiceModel>();
            CreateMap<ExamResource, ExamResourceServiceModel>();
        }
    }
}
