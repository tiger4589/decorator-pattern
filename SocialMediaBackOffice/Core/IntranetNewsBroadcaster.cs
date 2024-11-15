using SocialMediaBackOffice.Models;

namespace SocialMediaBackOffice.Core;

public class IntranetNewsBroadcaster : INewsBroadcaster
{
    public Task Broadcast(News news)
    {
        Console.WriteLine($"News published on intranet. Title: {news.Title}, Content: {news.Content}");
        return Task.CompletedTask;
    }
}