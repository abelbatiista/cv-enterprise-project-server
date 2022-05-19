using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.VacantUser;
using Server.Model.Repositories.VacantUser;
using VacantUserEntity = Server.Model.Entities.VacantUser.VacantUser;

namespace Server.Services.Services.VacantUser
{
    public interface IVacantUserService : IBaseService<VacantUserEntity, VacantUserDTO> { }

    public class VacantUserService : BaseService<VacantUserEntity, VacantUserDTO>, IVacantUserService
    {
        public VacantUserService(
            IVacantUserRepository repository,
            IMapper mapper,
            IValidator<VacantUserDTO> validator) : base(repository, mapper, validator) { }
    }
}
