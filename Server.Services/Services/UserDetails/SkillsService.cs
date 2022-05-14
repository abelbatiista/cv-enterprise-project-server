using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface ISkillsService : IBaseService<Skills, SkillsDTO> { }

    public class SkillsService : BaseService<Skills, SkillsDTO>, ISkillsService
    {
        public SkillsService(
            ISkillsRepository repository,
            IMapper mapper,
            IValidator<SkillsDTO> validator) : base(repository, mapper, validator) { }
    }
}