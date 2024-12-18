namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree;

public class TreeOperationManager
{
    public bool Goto(string path)
    {
        return TreeGotoAction.Run(path);
    }

    public bool List(int depth)
    {
        var somee = new TreeListAction(depth);
        return true;
    }
}