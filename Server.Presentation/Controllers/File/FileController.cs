using Microsoft.AspNetCore.Mvc;
using Server.Bl.DTOs.File;
using Server.Controllers;
using Server.Services.Services.File;
using FileEntity = Server.Model.Entities.File.File;

namespace Server.Presentation.Controllers.File
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet("[action]")]
        public async Task<Stream> Download([FromQuery] int userDetailsId)
        {
            var response = await _fileService.Download(userDetailsId);

            if (response is null)
                return null;

            return response.FileStream;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(IFormFile file, [FromQuery] int userDetailsId)
        {
            if (file is null)
                return UnprocessableEntity();

            var response = await _fileService.Upload(file, userDetailsId);

            return Ok(response);

        }
    }
}
