using System;

namespace SinglLogWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            var filelogwriter = FileLogWriter.GetInstance;
            filelogwriter.LogInfo("Message containing information");
            filelogwriter.LogWarning("Message containing warning");
            filelogwriter.LogError("Message containing error");

            var consolelogwriter = ConsoleLogWriter.GetInstance;
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
