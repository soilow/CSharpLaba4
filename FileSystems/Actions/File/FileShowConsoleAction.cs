namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.File;

public sealed class FileShowConsoleAction
{
    private FileShowConsoleAction() { }

    public static bool Run(string path)
    {
        try
        {
            foreach (string line in System.IO.File.ReadLines(Environment.CurrentDirectory + path).Take(20))
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
}