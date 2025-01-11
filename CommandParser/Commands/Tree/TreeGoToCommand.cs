using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Tree;

public class TreeGoToCommand : ICommand
{
    private readonly string _path;

    public TreeGoToCommand(string path)
    {
        _path = path;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.Tree()?.Goto(_path);

        return result is not (null or false);
    }
}