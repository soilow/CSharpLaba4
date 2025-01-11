using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.States;

public class DisconnectedState : IFileSystemState
{
    public FileOperationManager? File(FileOperationManager operationManager)
    {
        Console.WriteLine($"Access denied: disconnected");

        return null;
    }

    public TreeOperationManager? Tree(TreeOperationManager operationManager)
    {
        Console.WriteLine($"Access denied: disconnected");

        return null;
    }
}