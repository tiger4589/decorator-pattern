using AllPhiLogger.Configuration;
using AllPhiLogger.Core;
using AllPhiLogger.Extensions;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger>();
await logger.Log("Important message here!");

static IServiceProvider BuildServiceProvider()
{
    return new ServiceCollection()
        .AddLogger(new LoggerConfiguration
        {
            Filename = "placeholder",
            Path = "path",
            DateFormat = "dd/MM/yyyy HH:mm:ss",
            StackFrames = 2
        }).BuildServiceProvider();
}