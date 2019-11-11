using System;

namespace SinglLogWriter
{
    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        private static ConsoleLogWriter instance;
        private ConsoleLogWriter()
        { }
        public static ConsoleLogWriter GetInstance()
        {
            return instance ??
                (instance = new ConsoleLogWriter());
        }
        protected override void WriteMessage(string line) =>
            Console.WriteLine(line);
    }
}
