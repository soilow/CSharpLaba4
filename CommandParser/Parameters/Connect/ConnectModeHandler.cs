using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Parameters.Connect;

public class ConnectModeHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[1] == "-m")
        {
            var localConnectionMode = new LocalConnectionHandler();

            IReadOnlyList<string> pathAndMode = new List<string> { input[0], input[2] };

            return localConnectionMode.Handle(pathAndMode);
        }

        return base.Handle(input);
    }
}