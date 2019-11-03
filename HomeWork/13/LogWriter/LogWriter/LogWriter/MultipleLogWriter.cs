using System;
using System.IO;

namespace LogWriter
{
    class MultipleLogWriter : AbstractLogWriter, ILogWriter
    {
        public FileLogWriter FileWriter { get; set; }
        public ConsoleLogWriter ConsoleWriter { get; set; }
        public MultipleLogWriter(FileLogWriter fileWriter, ConsoleLogWriter consoleWriter)
        {
            FileWriter = fileWriter;
            ConsoleWriter = consoleWriter;
        }

        public override void LogInfo(string message)
        {
            FileWriter.LogInfo(message);
            ConsoleWriter.LogInfo(message);

        }
        public override void LogWarning(string message)
        {
            FileWriter.LogWarning(message);
            ConsoleWriter.LogWarning(message);
        }
        public override void LogError(string message)
        {
            FileWriter.LogError(message);
            ConsoleWriter.LogError(message);

        }
    }
}
