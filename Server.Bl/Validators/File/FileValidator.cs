using FluentValidation;
using Server.Bl.DTOs.User;

namespace Server.Bl.Validators.User
{
    public class FileValidator : AbstractValidator<UserDTO>
    {
        public FileValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email is required");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required")
                .MinimumLength(8)
                .WithMessage("Password's length must be at least 8 characters");
        }
    }
}
