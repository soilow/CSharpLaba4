using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File.ConsoleMode;

public class ConsoleShowHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[1] == "console")
        {
            return new FileShowCommand(input[0], new ConsoleShowMode());
        }

        return base.Handle(input);
    }
}