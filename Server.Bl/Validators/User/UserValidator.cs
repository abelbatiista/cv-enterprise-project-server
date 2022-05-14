using FluentValidation;
using Server.Bl.DTOs.File;

namespace Server.Bl.Validators.File
{
    public class FileValidator : AbstractValidator<FileDTO>
    {
        public FileValidator()
        {
        }
    }
}
