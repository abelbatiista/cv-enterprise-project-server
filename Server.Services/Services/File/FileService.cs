using AutoMapper;
using FluentValidation;
using Server.Bl.DTOs.File;
using FileEntity = Server.Model.Entities.File.File;
using FileSystem = System.IO.File;
using Server.Model.Repositories.File;
using Microsoft.AspNetCore.Http;
using Server.Core.Abstract;
using Server.Core.Settings;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;

namespace Server.Services.Services.File
{
    public interface IFileService : IBaseService<FileEntity, FileDTO> 
    {
        Task<IFileOperationResult<IFormFile>> Upload(IFormFile file, int userDetailsId);
        Task<FileStreamResult> Download(int userDetailsId);
    }

    public class FileService : BaseService<FileEntity, FileDTO>, IFileService
    {

        private readonly FileSettings _fileSettings;
        private readonly IFileRepository _fileRepository;
        public FileService(
            IFileRepository repository,
            IMapper mapper,
            IValidator<FileDTO> validator,
            IOptions<FileSettings> fileSettings
        ) 
        : base(repository, mapper, validator) 
        {
            _fileSettings = fileSettings.Value;
            _fileRepository = repository;
        }

        private async Task Save(IFormFile file, string folder)
        {
            using (var stream = new FileStream(path: folder, mode: FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }

        public async Task<FileStreamResult> Download(int userDetailsId)
        {
            var file = await _fileRepository.GetByUserId(userDetailsId);

            string folder = _fileSettings.Path;

            try
            {
                var fileName = file is null ? _fileSettings.NoImage : file.FileName;

                var completePath = Path.Combine(Directory.GetCurrentDirectory(), folder, fileName);

                if (!FileSystem.Exists(completePath))
                    return null;

                var content = FileSystem.OpenRead(completePath);

                var contentType = file is null ? _fileSettings.ContentType : file.ContentType;

                var fileStream = new FileStreamResult(content, contentType);

                return fileStream;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IFileOperationResult<IFormFile>> Upload(IFormFile file, int userDetailsId)
        {
            string folderPath = _fileSettings.Path;

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), folderPath)))
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), folderPath));

            var filePath = Path.Combine(folderPath, fileName);

            try
            {
                var fileExists = await _fileRepository.GetByUserId(userDetailsId);
                if (!(fileExists is null))
                {
                    await _fileRepository.Delete(fileExists.Id);
                    var completePath = Path.Combine(Directory.GetCurrentDirectory(), folderPath, fileExists.FileName);
                    FileSystem.Delete(completePath);
                }
                await Save(file, filePath);
                await _fileRepository.Add(new FileEntity
                {
                    FileName = fileName,
                    FileUrl = null,
                    OriginalName = file.FileName,
                    Path = filePath,
                    ContentType = file.ContentType,
                    ContentLength = file.ContentType.Length,
                    UserDetailsId = userDetailsId
                });
                return new FileOperationResult<IFormFile>
                {
                    IsSuccess = true,
                    Message = string.Format($"File {file.FileName} uploaded successfuly."),
                    Entity = file,
                    Path = filePath,
                    FileName = filePath.Replace(folderPath + "\\", string.Empty)
                };
            }
            catch (Exception e)
            {
                return new FileOperationResult<IFormFile>
                {
                    IsSuccess = false,
                    Message = e.Message,
                    Entity = file
                };
            }
        }
    }
}