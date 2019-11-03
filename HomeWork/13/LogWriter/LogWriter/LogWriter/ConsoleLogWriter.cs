using System;

namespace LogWriter
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void LogInfo(string message)
        {
            Console.WriteLine($"{base.Description("Info")}     {message}.");
        }
        public override void LogWarning(string message)
        {
            Console.WriteLine($"{base.Description("Warning")}      {message}.");
        }
        public override void LogError(string message)
        {
            Console.WriteLine($"{base.Description("Error")}      {message}.");
        }
    }
}
