using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Disconnect;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Disconnect;

public class DisconnectHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "disconnect")
        {
            return new DisconnectCommand();
        }

        return base.Handle(input);
    }
}