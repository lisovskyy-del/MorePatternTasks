namespace MainProgram.Composite;

public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new();

    public Directory(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public override int GetSize()
    {
        int result = 0;

        foreach (FileSystemComponent component in _components)
        {
            result += component.GetSize();
        }

        return result;
    }
}