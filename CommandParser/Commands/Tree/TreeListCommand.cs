using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Tree;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public bool Execute(IFileSystem fileSystem)
    {
        bool? result = fileSystem.Tree()?.List(_depth);

        return result is not (null or false);
    }
}