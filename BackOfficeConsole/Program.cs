using Microsoft.Extensions.DependencyInjection;
using SocialMediaBackOffice.Core;
using SocialMediaBackOffice.Decorators;
using SocialMediaBackOffice.Models;

var serviceProvider = BuildServiceProvider();
var newsBroadcaster = serviceProvider.GetRequiredService<INewsBroadcaster>();
await newsBroadcaster.Broadcast(new News
{
    Content = "Pretend this is a long content, please, pretty please?",
    Title = "AllPhi's upcoming Lightning talk"
});

static IServiceProvider BuildServiceProvider()
{
    return new ServiceCollection()
    .AddTransient<INewsBroadcaster, IntranetNewsBroadcaster>() //start by the concrete component
    .Decorate<INewsBroadcaster, FacebookNewsBroadcasterDecorator>() //decorate your interface with the concrete decorators
    .Decorate<INewsBroadcaster, LinkedInNewsBroadcasterDecorator>() 
    .BuildServiceProvider();
}