using System;

namespace SinglLogWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            var filelogwriter = FileLogWriter.Instance;
            filelogwriter.LogInfo("Message containing information");
            filelogwriter.LogWarning("Message containing warning");
            filelogwriter.LogError("Message containing error");

            var consolelogwriter = ConsoleLogWriter.Instance;
            consolelogwriter.LogInfo("Message containing information");
            consolelogwriter.LogWarning("Message containing warning");
            consolelogwriter.LogError("Message containing error");

            var miltipleogriter = MultipleLogWriter.Instance(consolelogwriter, filelogwriter);
            miltipleogriter.LogInfo("Message containing information");
            miltipleogriter.LogWarning("Message containing warning");
            miltipleogriter.LogError("Message containing error");

            Console.ReadKey();
        }
    }
}
