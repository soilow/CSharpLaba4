using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands.Connect;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.Connect;

public class LocalConnectionHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[1] == "local")
        {
            return new ConnectLocalSystemCommand(input[0]);
        }

        return base.Handle(input);
    }
}