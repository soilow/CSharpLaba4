using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Delete;

public class FileDeleteHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "delete")
        {
            return new FileDeleteCommand(input[1]);
        }

        return base.Handle(input);
    }
}