namespace MainProgram.Proxy;

class Menu
{
    public static void Run()
    {
        IVideoService manager = new CachedVideoService(new RealVideoService());

        Console.WriteLine("Get video #10:");
        Console.WriteLine(manager.GetVideo(10));

        Console.WriteLine("\nGet video #10 (repeat):");
        Console.WriteLine(manager.GetVideo(10));
    }
}
