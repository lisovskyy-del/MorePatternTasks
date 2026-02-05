namespace MainProgram.Logger;

public class FileWriter
{
    public static void Write(string text)
    {
        Console.Write(text);
    }

    public static void WriteLine(string text)
    {
        Console.WriteLine($"[FILE] >> {text}");
    }
}