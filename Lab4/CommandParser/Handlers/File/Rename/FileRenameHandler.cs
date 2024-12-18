using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.File;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Rename;

public class FileRenameHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "rename")
        {
            return new FileRenameCommand(input[1], input[2]);
        }

        return base.Handle(input);
    }
}