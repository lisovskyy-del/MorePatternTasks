namespace MainProgram.Proxy;

public class CachedVideoService : IVideoService
{
    private RealVideoService _realService;
    private Dictionary<int, string> _cache = new();

    public CachedVideoService(RealVideoService realService)
    {
        _realService = realService;
    }

    public string GetVideo(int videoId)
    {
        if (!_cache.ContainsKey(videoId))
        {
            string video = _realService.GetVideo(videoId);
            _cache[videoId] = video;
        }
        return _cache[videoId];
    }
}
