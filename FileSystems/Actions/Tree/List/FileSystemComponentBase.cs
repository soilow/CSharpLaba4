using System.Collections;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree.List;

public class FileSystemComponentBase : IEnumerable<FileSystemComponentBase>
{
    public string Name { get; init; }

    private char _nestingChar = ' ';
    private string _placeholder = "--";

    protected FileSystemComponentBase(string path)
    {
        Name = Path.GetFileName(path) ?? path;
    }

    public void SetNestingChar(char nestingChar) => _nestingChar = nestingChar;

    public void SetPlaceholder(string placeholder) => _placeholder = placeholder;

    public virtual void Print(int depth = 1)
    {
        Console.WriteLine(new string(_nestingChar, (depth - 1) * 2) + _placeholder + Name);
    }

    public virtual IEnumerator<FileSystemComponentBase> GetEnumerator()
    {
        yield break;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}