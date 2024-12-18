using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree.GouTo;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree.List;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree;

public class TreeHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "tree")
        {
            var treeHandlerGoto = new TreeGotoHandler();
            var treeHandlerList = new TreeListHandler();

            treeHandlerList.SetNext(treeHandlerGoto);

            return treeHandlerList.Handle(input.Skip(1).ToList());
        }

        return base.Handle(input);
    }
}