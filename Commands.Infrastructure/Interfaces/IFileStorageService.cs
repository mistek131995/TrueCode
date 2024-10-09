namespace Commands.Infrastructure.Interfaces;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(byte[] file, string fileName, string destinationPath);
    Task DeleteFileAsync(string filePath);
}