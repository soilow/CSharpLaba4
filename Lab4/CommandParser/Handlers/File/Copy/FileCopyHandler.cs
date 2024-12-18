using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Copy;

public class FileCopyHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "copy")
        {
            return new FileCopyCommand(input[1], input[2]);
        }

        return base.Handle(input);
    }
}