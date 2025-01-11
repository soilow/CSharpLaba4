namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public sealed class FileRenameAction
{
    private FileRenameAction() { }

    public static bool Run(string filePath, string newName)
    {
        try
        {
            System.IO.File.Move(Environment.CurrentDirectory + filePath, Environment.CurrentDirectory + newName);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}