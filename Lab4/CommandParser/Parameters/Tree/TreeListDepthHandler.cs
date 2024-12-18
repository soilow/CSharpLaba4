using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.Tree;

public class TreeListDepthHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "-d")
        {
            if (int.TryParse(input[1], out int depth))
            {
                return new TreeListCommand(depth);
            }

            return null;
        }

        return base.Handle(input);
    }
}