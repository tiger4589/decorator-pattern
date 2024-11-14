using AllPhiLogger.Core;

namespace AllPhiLogger.Decorators;

public abstract class BaseLoggerDecorator(ILogger logger) : ILogger
{
    public virtual async Task Log(string message)
    {
        await logger.Log(message);
    }
}