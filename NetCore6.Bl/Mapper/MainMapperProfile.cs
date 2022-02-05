using AutoMapper;
using NetCore6.Bl.DTOs;
using NetCore6.Model.Entities;

namespace NetCore6.Bl.Mapper
{
    public class MainMapperProfile : Profile
    {
        public MainMapperProfile()
        {
            CreateMap<ExamplePersonDTO, ExamplePerson>();
            CreateMap<ExamplePerson, ExamplePersonDTO>();
        }
    }
}