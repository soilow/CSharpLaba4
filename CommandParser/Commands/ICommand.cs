using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;

public interface ICommand
{
    bool Execute(IFileSystem fileSystem);
}