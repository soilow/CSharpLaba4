using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.Connect;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Connect;

public class ConnectHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "connect")
        {
            var connectModeHandler = new ConnectModeHandler();

            return connectModeHandler.Handle(input.Skip(1).ToList());
        }

        return base.Handle(input);
    }
}