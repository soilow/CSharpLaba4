using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File.ConsoleMode;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File;

public class FileShowModeHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[1] == "-m")
        {
            var consoleShow = new ConsoleShowHandler();

            IReadOnlyList<string> pathAndMode = new List<string> { input[0], input[2] };

            return consoleShow.Handle(pathAndMode);
        }

        return base.Handle(input);
    }
}