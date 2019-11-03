using System;

namespace LogWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new ConsoleLogWriter();
            var second = new FileLogWriter();
            var multiLogWriter = new MultipleLogWriter(second, first);

            Console.WriteLine($"\nType: {first.GetType()}");
            first.LogInfo("Message containing information");
            first.LogWarning("Message containing warning");
            first.LogError("Message containing error");

            Console.WriteLine($"\nType: {second.GetType()}");
            second.LogInfo("Message containing information");            
            second.LogWarning("Message containing warning");
            second.LogError("Message containing error");

            Console.WriteLine($"\nType: {multiLogWriter.GetType()}");
            multiLogWriter.LogInfo("Message containing information");
            multiLogWriter.LogWarning("Message containing warning");
            multiLogWriter.LogError("Message containing error");
        }
    }
} 
