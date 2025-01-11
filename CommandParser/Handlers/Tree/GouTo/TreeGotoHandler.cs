using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree.GouTo;

public class TreeGotoHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "goto")
        {
            return new TreeGoToCommand(input[1]);
        }

        return base.Handle(input);
    }
}