namespace MainProgram.Proxy;

public interface IVideoService
{
    string GetVideo(int videoId);
}

public class RealVideoService : IVideoService
{
    public string GetVideo(int videoId)
    {
        Console.WriteLine($"[RealService] Downloading video {videoId} from server...");
        Thread.Sleep(2000);
        return $"Video content {videoId}";
    }
}
