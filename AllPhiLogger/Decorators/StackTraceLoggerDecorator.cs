using System.Diagnostics;
using AllPhiLogger.Core;

namespace AllPhiLogger.Decorators;

public class StackTraceLoggerDecorator(ILogger logger, int framesNumber) : BaseLoggerDecorator(logger)
{
    public override async Task Log(string message)
    {
        var st = new StackTrace(framesNumber, false);
        message = $"{message} - Stack Trace: {st}";
        await base.Log(message);
    }
}