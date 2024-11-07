using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RoesteCrmServer.Domain.Services;
using File = RoesteCrmServer.Domain.Entities.File;

namespace RoesteCrmServer.Infrastructure.Services;

internal sealed class FileService(IWebHostEnvironment environment) : IFileService
{
    public async Task<File> SaveFileAsync(IFormFile file, string folderName, CancellationToken cancellationToken = default)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("Invalid file.");
        
        var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        var folderPath = Path.Combine(environment.WebRootPath, folderName);
        var fullPath = Path.Combine(folderPath, fileName);
        if(!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        await using (var stream = new FileStream(fullPath, FileMode.Create))
        {
            await file.CopyToAsync(stream, cancellationToken);
        }

        return new File { Path = fullPath, Extension = Path.GetExtension(file.FileName) };
    }

    public async Task<File[]> SaveFilesAsync(IEnumerable<IFormFile> files, string folderPath, CancellationToken cancellationToken = default)
    {
        var createdFiles = new List<File>();
        foreach (var file in files)
            createdFiles.Add(await SaveFileAsync(file, folderPath, cancellationToken));
        
        return createdFiles.ToArray();
    }

    public Task OpenFile(string filePath, string folderPath)
    {
        throw new NotImplementedException();
    }
}