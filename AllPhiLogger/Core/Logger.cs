using AllPhiLogger.Configuration;

namespace AllPhiLogger.Core;

public class Logger(LoggerConfiguration configuration) : ILogger
{
    public Task Log(string message)
    {
        Console.WriteLine(message);
        return Task.CompletedTask;
    }
}