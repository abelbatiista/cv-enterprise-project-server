using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IEducationService : IBaseService<Education, EducationDTO> { }

    public class EducationService : BaseService<Education, EducationDTO>, IEducationService
    {
        public EducationService(
            IEducationRepository repository,
            IMapper mapper,
            IValidator<EducationDTO> validator) : base(repository, mapper, validator) { }
    }
}
