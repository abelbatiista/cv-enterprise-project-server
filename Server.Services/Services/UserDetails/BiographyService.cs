using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IBiographyService : IBaseService<Biography, BiographyDTO> { }

    public class BiographyService : BaseService<Biography, BiographyDTO>, IBiographyService
    {
        public BiographyService(
            IBiographyRepository repository,
            IMapper mapper,
            IValidator<BiographyDTO> validator) : base(repository, mapper, validator) { }
    }
}