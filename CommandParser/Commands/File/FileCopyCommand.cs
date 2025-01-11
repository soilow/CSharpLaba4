using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

public class FileCopyCommand : ICommand
{
    private readonly string _source;
    private readonly string _destination;

    public FileCopyCommand(string source, string destination)
    {
        _source = source;
        _destination = destination;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.File()?.Copy(_source, _destination);

        return result is not (null or false);
    }
}