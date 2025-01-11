namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public sealed class FileCopyAction
{
    private FileCopyAction() { }

    public static bool Run(string sourcePath, string destinationPath)
    {
        try
        {
            System.IO.File.Copy(Environment.CurrentDirectory + sourcePath, Environment.CurrentDirectory + destinationPath, overwrite: true);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}