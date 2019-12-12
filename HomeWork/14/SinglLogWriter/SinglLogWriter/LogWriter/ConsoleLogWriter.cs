using System;

namespace SinglLogWriter
{
    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        private static ConsoleLogWriter _instance;
        private ConsoleLogWriter()
        { }

        public static ConsoleLogWriter Instance
        {
            get
            {
                return _instance ??
                    (_instance = new ConsoleLogWriter());
            }
        }
        protected override void WriteMessage(string line) =>
            Console.WriteLine(line);
    }
}
