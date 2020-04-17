using System.Collections.Generic;

namespace DesignPatterns
{
    public interface ILogger
    {
        List<string> MessageLogs { get; set; }
    }
}