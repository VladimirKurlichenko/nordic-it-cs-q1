﻿using System;

namespace LogWriter
{
    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        protected override void WriteMessage(string line) =>
            Console.WriteLine(line);
    }
}
