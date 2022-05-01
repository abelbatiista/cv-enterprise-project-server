using FluentValidation;
using NetCore6.Bl.DTOs;

namespace NetCore6.Bl.Validators
{
    public class ExamplePersonValidator: AbstractValidator<ExamplePersonDTO>
    {
        public ExamplePersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is required");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .WithMessage("LastName is required");
        }
    }
}