using Commands.Infrastructure.Interfaces;

namespace Commands.Infrastructure.Services;

public class FileStorageService(string baseFolder) : IFileStorageService
{
    
    public async Task<string> SaveFileAsync(byte[] file, string fileName, string destinationPath)
    {
        fileName = $"{Guid.NewGuid()}_{fileName}";
        var path = Path.Combine(baseFolder, destinationPath, fileName);
        
        await File.WriteAllBytesAsync(path, file);

        return path;
    }

    public async Task DeleteFileAsync(string filePath)
    {
        if(File.Exists(filePath))
            File.Delete(filePath);
        
        await Task.CompletedTask;
    }
}