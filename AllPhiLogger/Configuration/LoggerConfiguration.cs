namespace AllPhiLogger.Configuration;

public class LoggerConfiguration
{
    public required string Path { get; set; }
    public required string Filename { get; set; }
    public string? DateFormat { get; set; }
    public int? StackFrames { get; set; }
}