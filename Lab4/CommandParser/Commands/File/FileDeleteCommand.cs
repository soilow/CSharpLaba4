using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

public class FileDeleteCommand : ICommand
{
    private readonly string _path;

    public FileDeleteCommand(string path)
    {
        _path = path;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.File()?.Delete(_path);

        return result is not (null or false);
    }
}