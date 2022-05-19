using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.Enterprise;
using EnterpriseEntity = Server.Model.Entities.Enterprise.Enterprise;
using Server.Model.Repositories.Enterprise;

namespace Server.Services.Services.Enterprise
{
    public interface IEnterpriseService : IBaseService<EnterpriseEntity, EnterpriseDTO> { }

    public class EnterpriseService : BaseService<EnterpriseEntity, EnterpriseDTO>, IEnterpriseService
    {
        public EnterpriseService(
            IEnterpriseRepository repository,
            IMapper mapper,
            IValidator<EnterpriseDTO> validator) : base(repository, mapper, validator) { }
    }
}
