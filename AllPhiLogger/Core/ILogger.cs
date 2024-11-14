namespace AllPhiLogger.Core;

public interface ILogger
{
    Task Log(string message);
}