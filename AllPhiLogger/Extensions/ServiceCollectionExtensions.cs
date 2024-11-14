using AllPhiLogger.Configuration;
using AllPhiLogger.Core;
using AllPhiLogger.Decorators;
using Microsoft.Extensions.DependencyInjection;

namespace AllPhiLogger.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLogger(this IServiceCollection services, LoggerConfiguration configuration)
    {
        services.AddSingleton<ILogger, Logger>((_) => new Logger(configuration));

        if (!string.IsNullOrWhiteSpace(configuration.DateFormat))
        {
            services.Decorate<ILogger>((inner) =>
                new TimestampLoggerDecorator(inner, configuration.DateFormat));
        }

        if (configuration.StackFrames != null)
        {
            services.Decorate<ILogger>((inner) =>
                new StackTraceLoggerDecorator(inner, configuration.StackFrames.Value));
        }

        return services;
    }
}