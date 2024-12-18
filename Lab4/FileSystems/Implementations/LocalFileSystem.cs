using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.States;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Implementations;

public class LocalFileSystem : IFileSystem
{
    private readonly FileOperationManager _fileOperationManager;
    private readonly TreeOperationManager _treeOperationManager;

    private IFileSystemState _state = new DisconnectedState();

    public LocalFileSystem()
    {
        _fileOperationManager = new FileOperationManager();
        _treeOperationManager = new TreeOperationManager();
    }

    public void ChangeState(IFileSystemState state)
    {
        _state = state;
    }

    public bool Connect(string path)
    {
        if (_state is ConnectedState)
        {
            Console.WriteLine("Сonnection is already established");

            return false;
        }

        Environment.CurrentDirectory = path;

        ChangeState(new ConnectedState());

        return true;
    }

    public bool Disconnect()
    {
        if (_state is DisconnectedState)
        {
            Console.WriteLine("Disconnected already");

            return false;
        }

        ChangeState(new DisconnectedState());

        return true;
    }

    public FileOperationManager? File()
    {
        return _state.File(_fileOperationManager);
    }

    public TreeOperationManager? Tree()
    {
        return _state.Tree(_treeOperationManager);
    }
}