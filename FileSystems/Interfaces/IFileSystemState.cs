using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

public interface IFileSystemState
{
    FileOperationManager? File(FileOperationManager operationManager);

    TreeOperationManager? Tree(TreeOperationManager operationManager);
}