using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Disconnect;

public class DisconnectCommand : ICommand
{
    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.Disconnect();
    }
}