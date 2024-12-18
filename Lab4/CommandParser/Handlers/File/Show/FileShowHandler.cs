using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.File;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Show;

public class FileShowHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "show")
        {
            var fileShowMode = new FileShowModeHandler();

            return fileShowMode.Handle(input.Skip(1).ToList());
        }

        return base.Handle(input);
    }
}