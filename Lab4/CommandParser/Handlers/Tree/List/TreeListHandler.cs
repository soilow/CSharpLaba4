using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree.List;

public class TreeListHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "list")
        {
            var listDepthParameter = new TreeListDepthHandler();

            return listDepthParameter.Handle(input.Skip(1).ToList());
        }

        return base.Handle(input);
    }
}