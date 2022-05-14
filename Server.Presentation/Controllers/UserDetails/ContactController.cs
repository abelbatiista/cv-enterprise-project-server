using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.UserDetails;
using Server.Controllers;
using Server.Services.Services.UserDetails;
using Server.Model.Entities.UserDetails;

namespace Server.Presentation.Controllers.UserDetails
{
    public class ContactController : BaseController<Contact, ContactDTO>
    {
        public ContactController(IContactService service) : base(service) { }
    }
}