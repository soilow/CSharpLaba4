namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystems.Actions.Tree.List;

public class DirectoryComponent : FileSystemComponentBase
{
    private readonly int _maxDepth;
    private readonly string _path;
    private readonly List<FileSystemComponentBase> _children;

    public DirectoryComponent(string path, int depth) : base(path)
    {
        _path = path;
        _maxDepth = depth;
        _children = new();
    }

    public void Add(FileSystemComponentBase component)
    {
        _children.Add(component);
    }

    public void BuildTree(int currentDepth = 0)
    {
        if (currentDepth >= _maxDepth) return;

        try
        {
            foreach (string file in Directory.GetFiles(_path))
            {
                if (Path.GetFileName(file) == ".DS_Store")
                    continue;

                _children.Add(new FileComponent(Path.GetFileName(file)));
            }

            foreach (string directory in Directory.GetDirectories(_path))
            {
                var subDirectory = new DirectoryComponent(directory, _maxDepth);
                _children.Add(subDirectory);
                subDirectory.BuildTree(currentDepth + 1);
            }
        }
        catch (Exception)
        {
            return;
        }
    }

    public override void Print(int depth = 1)
    {
        base.Print(depth);

        foreach (FileSystemComponentBase child in _children)
        {
            child.Print(depth + 1);
        }
    }

    public override IEnumerator<FileSystemComponentBase> GetEnumerator()
    {
        foreach (FileSystemComponentBase child in _children)
        {
            yield return child;
        }
    }
}