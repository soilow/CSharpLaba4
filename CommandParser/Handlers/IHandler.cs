using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public interface IHandler
{
    IHandler SetNext(IHandler handler);

    ICommand? Handle(IReadOnlyList<string> input);
}