using System;

namespace LogWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new ConsoleLogWriter();
            var second = new FileLogWriter();

            first.LogInfo("Message containing information");
            second.LogInfo("Message containing information");

            first.LogWarning("Message containing warning");            second.LogWarning("Message containing warning");

            first.LogError("Message containing error");
            second.LogError("Message containing error");
        }
    }
} 
