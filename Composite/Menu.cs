namespace MainProgram.Composite;

class Menu
{
    public static void Run()
    {
        var root = new Directory("Root");
        var movie = new File("Inception.mkv", 2000);

        var docsFolder = new Directory("Documents");
        docsFolder.Add(new File("Resume.pdf", 10));
        docsFolder.Add(new File("Picture.png", 5));

        root.Add(movie);
        root.Add(docsFolder);

        Console.WriteLine($"Size of Root: {root.GetSize()} MB");
    }
}
