using Microsoft.AspNetCore.Http;
using File = RoesteCrmServer.Domain.Entities.File;

namespace RoesteCrmServer.Domain.Services;

public interface IFileService
{
    Task<File> SaveFileAsync(IFormFile file, string folderPath, CancellationToken cancellationToken = default);
    Task<File[]> SaveFilesAsync(IEnumerable<IFormFile> files, string folderPath, CancellationToken cancellationToken = default);
    Task OpenFile(string filePath, string folderPath);
}