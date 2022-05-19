using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using UserDetailsEntity = Server.Model.Entities.UserDetails.UserDetails;
using Server.Model.Repositories.UserDetails;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Server.Services.Services.UserDetails
{
    public interface IUserDetailsService : IBaseService<UserDetailsEntity, UserDetailsDTO> 
    {
        Task<UserDetailsDTO> GetByApplicationIdentityUserId(string applicationIdentityUserId);
    }

    public class UserDetailsService : BaseService<UserDetailsEntity, UserDetailsDTO>, IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        public UserDetailsService(
            IUserDetailsRepository repository,
            IMapper mapper,
            IValidator<UserDetailsDTO> validator) 
        : base(repository, mapper, validator
        ) 
        {
            _userDetailsRepository = repository;
        }

        public async Task<UserDetailsDTO> GetByApplicationIdentityUserId(string applicationIdentityUserId)
        {
            //var entity = await _userDetailsRepository.GetByApplicationIdentityUserId(applicationIdentityUserId);
            //var dto = _mapper.Map<UserDetailsDTO>(entity);
            //return dto;
            var query = base.AsQuery();
            var list = query.ProjectTo<UserDetailsDTO>(_mapper.ConfigurationProvider);
            var dto = await list.Where(x => x.ApplicationIdentityUserId == applicationIdentityUserId).FirstOrDefaultAsync();
            return dto;
        }
    }
}
