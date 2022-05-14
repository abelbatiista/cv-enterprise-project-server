using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IWorkPlataformService : IBaseService<WorkPlataform, WorkPlataformDTO> { }

    public class WorkPlataformService : BaseService<WorkPlataform, WorkPlataformDTO>, IWorkPlataformService
    {
        public WorkPlataformService(
            IWorkPlataformRepository repository,
            IMapper mapper,
            IValidator<WorkPlataformDTO> validator) : base(repository, mapper, validator) { }
    }
}