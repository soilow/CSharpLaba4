using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File.ConsoleMode;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public class FileOperationManager
{
    public bool Show(string path, IFileShowMode mode)
    {
        if (mode is ConsoleShowMode)
        {
            return FileShowConsoleAction.Run(path);
        }

        return false;
    }

    public bool Rename(string filePath, string newName)
    {
        return FileRenameAction.Run(filePath, newName);
    }

    public bool Move(string filePath, string newPath)
    {
        return FileMoveAction.Run(filePath, newPath);
    }

    public bool Copy(string filePath, string newPath)
    {
        return FileCopyAction.Run(filePath, newPath);
    }

    public bool Delete(string filePath)
    {
        return FileDeleteAction.Run(filePath);
    }
}