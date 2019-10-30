using System;
using System.IO;

namespace LogWriter
{
    class MultipleLogWriter : AbstractLogWriter, ILogWriter
    {
        public string MessageInfo { get; set; }
        public string MessageWarning { get; set; }
        public string MessageError { get; set; }
        public MultipleLogWriter(string messageInfo, string messageWarning, string messageError)
        {
            MessageInfo = messageInfo;
            MessageWarning = messageWarning;
            MessageError = messageError;
        }
        public override void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Info    {message}. ");
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Info    {message}. ");
        }
        public override void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Warning    {message}. ");
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Warning    {message}. ");
        }
        public override void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now}      Error    {message}. ");
            File.AppendAllText(@"C:\Users\vovak\OneDrive\Desktop\Log.txt", $"{DateTime.Now}      Error    {message}. ");
        }
    }
}
