using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

public class FileRenameCommand : ICommand
{
    private readonly string _path;
    private readonly string _fileName;

    public FileRenameCommand(string path, string fileName)
    {
        _path = path;
        _fileName = fileName;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.File()?.Rename(_path, _fileName);

        return result is not (null or false);
    }
}