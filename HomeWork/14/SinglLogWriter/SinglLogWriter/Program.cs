using System;

namespace SinglLogWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a file name: ");
            var path = Console.ReadLine();

            var filelogwriter = FileLogWriter.GetInstance(path);
            filelogwriter.LogInfo("Message containing information");
            filelogwriter.LogWarning("Message containing warning");
            filelogwriter.LogError("Message containing error");

            var consolelogwriter = ConsoleLogWriter.GetInstance();
            consolelogwriter.LogInfo("Message containing information");
            consolelogwriter.LogWarning("Message containing warning");
            consolelogwriter.LogError("Message containing error");

            var miltipleogriter = MultipleLogWriter.GetInstance(consolelogwriter, filelogwriter);
            miltipleogriter.LogInfo("Message containing information");
            miltipleogriter.LogWarning("Message containing warning");
            miltipleogriter.LogError("Message containing error");

            Console.ReadKey();
        }
    }
}
