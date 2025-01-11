using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree.List;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;

public class TreeListAction
{
    public TreeListAction(int depth)
    {
        var root = new DirectoryComponent(Environment.CurrentDirectory, depth);
        root.BuildTree();

        foreach (FileSystemComponentBase component in root)
        {
            component.Print();
        }
    }
}