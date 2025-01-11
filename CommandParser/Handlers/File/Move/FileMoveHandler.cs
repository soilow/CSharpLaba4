using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Move;

public class FileMoveHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "move")
        {
            return new FileMoveCommand(input[1], input[2]);
        }

        return base.Handle(input);
    }
}