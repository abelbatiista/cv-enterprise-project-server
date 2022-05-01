using AutoMapper;
using FluentValidation;
using NetCore6.Bl.DTOs;
using NetCore6.Model.Entities;
using NetCore6.Model.Repositories;

namespace NetCore6.Services.Services
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