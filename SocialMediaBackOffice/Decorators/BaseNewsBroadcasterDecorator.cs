using SocialMediaBackOffice.Core;
using SocialMediaBackOffice.Models;

namespace SocialMediaBackOffice.Decorators;

public abstract class BaseNewsBroadcasterDecorator : INewsBroadcaster
{
    private readonly INewsBroadcaster _newsBroadcaster;

    protected BaseNewsBroadcasterDecorator(INewsBroadcaster newsBroadcaster)
    {
        _newsBroadcaster = newsBroadcaster;
    }

    public virtual Task Broadcast(News news)
    {
        return _newsBroadcaster.Broadcast(news);
    }
}