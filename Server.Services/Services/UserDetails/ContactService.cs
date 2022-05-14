using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.UserDetails;
using Server.Model.Entities.UserDetails;
using Server.Model.Repositories.UserDetails;

namespace Server.Services.Services.UserDetails
{
    public interface IContactService : IBaseService<Contact, ContactDTO> { }

    public class ContactService : BaseService<Contact, ContactDTO>, IContactService
    {
        public ContactService(
            IContactRepository repository,
            IMapper mapper,
            IValidator<ContactDTO> validator) : base(repository, mapper, validator) { }
    }
}
