using AutoMapper;
using Server.Bl.DTOs;
using Server.Bl.DTOs.Enterprise;
using Server.Bl.DTOs.File;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities;
using Server.Model.Entities.Enterprise;
using Server.Model.Entities.UserDetails;
using FileEntity = Server.Model.Entities.File.File;
using EnterpriseEntity = Server.Model.Entities.Enterprise.Enterprise;
using VacantUserEntity = Server.Model.Entities.VacantUser.VacantUser;
using Server.Bl.DTOs.VacantUser;

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
            CreateMap<EnterpriseEntity, EnterpriseDTO>().ReverseMap();
            CreateMap<Vacant, VacantDTO>().ReverseMap();
            CreateMap<VacantUserEntity, VacantUserDTO>().ReverseMap();
        }
    }
}