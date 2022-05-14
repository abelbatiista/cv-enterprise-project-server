using AutoMapper;
using Server.Bl.DTOs;
using Server.Bl.DTOs.File;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities;
using Server.Model.Entities.UserDetails;
using FileEntity = Server.Model.Entities.File.File;

namespace Server.Bl.Mapper
{
    public class MainMapperProfile : Profile
    {
        public MainMapperProfile()
        {
            CreateMap<ExamplePerson, ExamplePersonDTO>().ReverseMap();
            CreateMap<Biography, BiographyDTO>().ReverseMap();
            CreateMap<Contact, ContactDTO>().ReverseMap();
            CreateMap<Education, EducationDTO>().ReverseMap();
            CreateMap<GeneralInformation, GeneralInformationDTO>().ReverseMap();
            CreateMap<Skills, SkillsDTO>().ReverseMap();
            CreateMap<Social, SocialDTO>().ReverseMap();
            CreateMap<UserDetails, UserDetailsDTO>().ReverseMap();
            CreateMap<WorkExperience, WorkExperienceDTO>().ReverseMap();
            CreateMap<WorkPlataform, WorkPlataformDTO>().ReverseMap();
            CreateMap<FileEntity, FileDTO>().ReverseMap();
        }
    }
}