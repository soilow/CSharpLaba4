using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Copy;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Delete;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Move;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Rename;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File.Show;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers.File;

public class FileHandler : HandlerBase
{
    public override ICommand? Handle(IReadOnlyList<string> input)
    {
        if (input[0] == "file")
        {
            var fileShowHandler = new FileShowHandler();
            var fileRenameHandler = new FileRenameHandler();
            var fileMoveHandler = new FileMoveHandler();
            var fileDeleteHandler = new FileDeleteHandler();
            var fileCopyHandler = new FileCopyHandler();

            fileShowHandler
                .SetNext(fileRenameHandler)
                .SetNext(fileMoveHandler)
                .SetNext(fileDeleteHandler)
                .SetNext(fileCopyHandler);

            return fileShowHandler.Handle(input.Skip(1).ToList());
        }

        return base.Handle(input);
    }
}