using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.Enterprise;
using Server.Model.Entities.Enterprise;
using Server.Model.Repositories.Enterprise;

namespace Server.Services.Services.Enterprise
{
    public interface IVacantService : IBaseService<Vacant, VacantDTO> { }

    public class VacantService : BaseService<Vacant, VacantDTO>, IVacantService
    {
        public VacantService(
            IVacantRepository repository,
            IMapper mapper,
            IValidator<VacantDTO> validator) : base(repository, mapper, validator) { }
    }
}
