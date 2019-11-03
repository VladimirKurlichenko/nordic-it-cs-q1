using System;
using System.IO;

namespace LogWriter
{
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        public override void LogInfo(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{base.Description("Info")}     {message}.");
        }
        public override void LogWarning(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{base.Description("Warning")}      {message}.");
        }
        public override void LogError(string message)
        {
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{base.Description("Error")}      {message}.");
        }
    }
}
