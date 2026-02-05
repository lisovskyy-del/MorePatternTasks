namespace MainProgram.Logger;

public interface ILogger
{
    void Log(string message);
    void Error(string message);
}

public class FileLoggerAdapter : ILogger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(FileWriter fileWriter)
    {
        _fileWriter = fileWriter;
    }

    public void Log(string message)
    {
        FileWriter.WriteLine(message);
    }

    public void Error(string message)
    {
        FileWriter.Write($"ERROR: {message}");
    }
}
