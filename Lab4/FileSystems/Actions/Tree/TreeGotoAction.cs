namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;

public sealed class TreeGotoAction
{
    private TreeGotoAction() { }

    public static bool Run(string path)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(path) || path.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
            {
                return false;
            }

            string fullPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), path));

            if (!Directory.Exists(fullPath))
            {
                return false;
            }

            Environment.CurrentDirectory = fullPath;

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}