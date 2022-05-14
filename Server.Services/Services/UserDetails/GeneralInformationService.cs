using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IGeneralInformationService : IBaseService<GeneralInformation, GeneralInformationDTO> { }

    public class GeneralInformationService : BaseService<GeneralInformation, GeneralInformationDTO>, IGeneralInformationService
    {
        public GeneralInformationService(
            IGeneralInformationRepository repository,
            IMapper mapper,
            IValidator<GeneralInformationDTO> validator) : base(repository, mapper, validator) { }
    }
}
