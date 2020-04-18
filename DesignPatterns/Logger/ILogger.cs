using System.Collections.Generic;

namespace DesignPatterns.Logger
{
    public interface ILogger
    {
        List<string> MessageLogs { get; set; }
    }
}