using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser;

public class Parser
{
    private readonly IHandler _initHandler;

    public Parser(IHandler initHandler)
    {
        _initHandler = initHandler;
    }

    public ICommand? Parse(string input)
    {
        IReadOnlyList<string> parts = input.Split(' ').ToList();

        return _initHandler?.Handle(parts);
    }
}