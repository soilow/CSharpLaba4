using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Connect;

public class ConnectLocalSystemCommand : ICommand
{
    private readonly string _path;

    public ConnectLocalSystemCommand(string pathToConnect)
    {
        _path = pathToConnect;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.Connect(_path);
    }
}