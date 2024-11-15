using SocialMediaBackOffice.Core;
using SocialMediaBackOffice.Models;

namespace SocialMediaBackOffice.Decorators;

public class LinkedInNewsBroadcasterDecorator : BaseNewsBroadcasterDecorator
{
    public LinkedInNewsBroadcasterDecorator(INewsBroadcaster newsBroadcaster) : base(newsBroadcaster)
    {
    }

    public override Task Broadcast(News news)
    {
        //Get LinkedIn credentials
        //Call their API

        Console.WriteLine($"News published to LinkedIn: {news.Title}{Environment.NewLine}{news.Content}");
        return base.Broadcast(news);
    }
}