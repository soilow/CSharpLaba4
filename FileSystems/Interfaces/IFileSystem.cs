using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;

public interface IFileSystem
{
    bool Connect(string path);

    bool Disconnect();

    void ChangeState(IFileSystemState state);

    FileOperationManager? File();

    TreeOperationManager? Tree();
}