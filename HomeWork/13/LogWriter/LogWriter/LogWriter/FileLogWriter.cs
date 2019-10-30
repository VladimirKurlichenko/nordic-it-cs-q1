using System;
using System.IO;

namespace LogWriter
{
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        public override void LogInfo(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Info    {message}. ");
        }
        public override void LogWarning(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Warning    {message}. ");
        }
        public override void LogError(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Error    {message}. ");
        }
    }
}
