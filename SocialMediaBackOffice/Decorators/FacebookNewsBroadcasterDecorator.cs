using SocialMediaBackOffice.Core;
using SocialMediaBackOffice.Models;

namespace SocialMediaBackOffice.Decorators;

public class FacebookNewsBroadcasterDecorator : BaseNewsBroadcasterDecorator
{
    public FacebookNewsBroadcasterDecorator(INewsBroadcaster newsBroadcaster) : base(newsBroadcaster)
    {
    }

    public override Task Broadcast(News news)
    {
        //Get Facebook credentials
        //Call the API

        Console.WriteLine($"Posted to facebook: {news.Title}{Environment.NewLine}{news.Content}");
        return base.Broadcast(news);
    }
}