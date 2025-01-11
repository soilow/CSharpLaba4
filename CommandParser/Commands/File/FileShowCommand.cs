using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

public class FileShowCommand : ICommand
{
    private readonly string _path;
    private readonly IFileShowMode _mode;

    public FileShowCommand(string path, IFileShowMode mode)
    {
        _path = path;
        _mode = mode;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.File()?.Show(_path, _mode);

        return result is not (null or false);
    }
}