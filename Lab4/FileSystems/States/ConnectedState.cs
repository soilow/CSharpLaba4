using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.States;

public class ConnectedState : IFileSystemState
{
    public FileOperationManager? File(FileOperationManager operationManager)
    {
        return operationManager;
    }

    public TreeOperationManager? Tree(TreeOperationManager operationManager)
    {
        return operationManager;
    }
}