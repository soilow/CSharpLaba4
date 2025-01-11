namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public sealed class FileMoveAction
{
    private FileMoveAction() { }

    public static bool Run(string source, string destination)
    {
        try
        {
            System.IO.File.Move(Environment.CurrentDirectory + source, Environment.CurrentDirectory + destination);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}