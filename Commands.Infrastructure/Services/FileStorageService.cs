using Commands.Infrastructure.Interfaces;

namespace Commands.Infrastructure.Services;

public class FileStorageService(string baseFolder) : IFileStorageService
{
    
    public async Task<string> SaveFileAsync(byte[] file, string fileName, string destinationPath)
    {
        fileName = $"{Guid.NewGuid()}_{fileName}";
        var directory = Path.Combine(baseFolder, destinationPath);
        var path = Path.Combine(directory, fileName);
        
        if(!Path.Exists(directory))
            Directory.CreateDirectory(directory);
        
        await File.WriteAllBytesAsync(path, file);

        return path.Replace(baseFolder, string.Empty);
    }

    public async Task DeleteFileAsync(string filePath)
    {
        if(File.Exists(filePath))
            File.Delete(filePath);
        
        await Task.CompletedTask;
    }
}