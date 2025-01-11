namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public sealed class FileDeleteAction
{
    private FileDeleteAction() { }

    public static bool Run(string fileName)
    {
        try
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + fileName))
            {
                System.IO.File.Delete(Environment.CurrentDirectory + fileName);
            }
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}