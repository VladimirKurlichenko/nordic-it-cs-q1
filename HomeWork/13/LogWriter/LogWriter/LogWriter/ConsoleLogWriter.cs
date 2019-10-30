using System;

namespace LogWriter
{
    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        public override void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Info    {message}. ");
        }
        public override void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Warning    {message}. ");
        }
        public override void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Error    {message}. ");
        }
    }
}
