using System;

namespace LogWriter2
{
    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        protected override void WriteMessage(string line) =>
            Console.WriteLine(line);
    }
}
