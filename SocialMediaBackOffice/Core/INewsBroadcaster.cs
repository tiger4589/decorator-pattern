using SocialMediaBackOffice.Models;

namespace SocialMediaBackOffice.Core;

public interface INewsBroadcaster
{
    Task Broadcast(News news);
}