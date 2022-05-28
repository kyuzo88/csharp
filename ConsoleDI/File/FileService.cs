using Microsoft.VisualBasic.FileIO;
using SearchOption = System.IO.SearchOption;

namespace ConsoleDI.File;

public interface IFileService
{
    Task<List<string>> GetFilesFromDirectory(string directoryPath);
}

public class FileService : IFileService
{
    public Task<List<string>> GetFilesFromDirectory(string directoryPath)
    {

        var files = Directory.EnumerateFiles(directoryPath, "", SearchOption.AllDirectories).ToList();
        return Task.FromResult(files);
    }
}