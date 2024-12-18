using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

public class FileMoveCommand : ICommand
{
    private readonly string _source;
    private readonly string _destination;

    public FileMoveCommand(string source, string destination)
    {
        _source = source;
        _destination = destination;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.File()?.Move(_source, _destination);

        return result is not (null or false);
    }
}