using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs;
using Server.Model.Entities;
using Server.Model.Repositories;

namespace Server.Services.Services
{
    public interface IExamplePersonService : IBaseService<ExamplePerson, ExamplePersonDTO> { }

    public class ExamplePersonService : BaseService<ExamplePerson, ExamplePersonDTO>, IExamplePersonService
    {
        public ExamplePersonService(
            IExamplePersonRepository repository,
            IMapper mapper,
            IValidator<ExamplePersonDTO> validator) : base(repository, mapper, validator) { }
    }
}