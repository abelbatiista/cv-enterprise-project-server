using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface ISocialService : IBaseService<Social, SocialDTO> { }

    public class SocialService : BaseService<Social, SocialDTO>, ISocialService
    {
        public SocialService(
            ISocialRepository repository,
            IMapper mapper,
            IValidator<SocialDTO> validator) : base(repository, mapper, validator) { }
    }
}