using System;

namespace LogWriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a file name: ");
            var path = Console.ReadLine();

            var filelogwriter = new FileLogWriter(path);
            filelogwriter.LogInfo("Message containing information");
            filelogwriter.LogWarning("Message containing warning");
            filelogwriter.LogError("Message containing error");

            var consolelogwriter = new ConsoleLogWriter();
            consolelogwriter.LogInfo("Message containing information");
            consolelogwriter.LogWarning("Message containing warning");
            consolelogwriter.LogError("Message containing error");

            var miltipleogriter = new MultipleLogWriter(consolelogwriter, filelogwriter);
            miltipleogriter.LogInfo("Message containing information");
            miltipleogriter.LogWarning("Message containing warning");
            miltipleogriter.LogError("Message containing error");

            Console.ReadKey();
        }
    }
}
