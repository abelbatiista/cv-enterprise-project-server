using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IWorkExperienceService : IBaseService<WorkExperience, WorkExperienceDTO> { }

    public class WorkExperienceService : BaseService<WorkExperience, WorkExperienceDTO>, IWorkExperienceService
    {
        public WorkExperienceService(
            IWorkExperienceRepository repository,
            IMapper mapper,
            IValidator<WorkExperienceDTO> validator) : base(repository, mapper, validator) { }
    }
}
