using Itmo.ObjectOrientedProgramming.Lab4.CommandParser;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Connect;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Disconnect;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.Tree;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Implementations;

namespace Itmo.ObjectOrientedProgramming.Lab4;

// /Users/soilow/Documents/Projects/C#/OOP/Laba4Sandbox
// /Users/soilow/Documents/Projects/C#/OOP/Laba4Sandbox/Python
public class Testings
{
    public static void Main()
    {
        var fileSystem = new LocalFileSystem();
        var connect = new ConnectHandler();
        var tree = new TreeHandler();
        var disconnect = new DisconnectHandler();
        var file = new FileHandler();

        file.SetNext(tree).SetNext(connect).SetNext(disconnect);

        var parser = new Parser(file);

        while (true)
        {
            string? userInput = Console.ReadLine();

            if (userInput is null)
                continue;

            ICommand? command = parser.Parse(userInput);
            command?.Execute(fileSystem);
        }
    }
}