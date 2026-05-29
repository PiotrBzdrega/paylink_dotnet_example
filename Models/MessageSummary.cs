using System;

namespace BlazorEmpty.Models;

public class MessageSummary
{
    public DateTime Timestamp { get; set; }
    public required string Message { get; set; }
    public required string Level { get; set; }
}
