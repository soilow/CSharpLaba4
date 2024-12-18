using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public class HandlerBase : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;

        return handler;
    }

    public virtual ICommand? Handle(IReadOnlyList<string> input)
    {
        if (_nextHandler is not null)
        {
            return _nextHandler.Handle(input);
        }

        return null;
    }
}