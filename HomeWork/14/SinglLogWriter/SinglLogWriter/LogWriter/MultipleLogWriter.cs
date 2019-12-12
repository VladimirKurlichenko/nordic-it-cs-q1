using System;
using System.IO;

namespace SinglLogWriter
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly ILogWriter[] _logWriters;
        private static MultipleLogWriter _instance;
        private MultipleLogWriter(params ILogWriter[] writer)
        {
            _logWriters = writer;
        }
        public static MultipleLogWriter Instance(params ILogWriter[] _logwriters)
        {
            return _instance ??
                (_instance = new MultipleLogWriter(_logwriters));
        }
        public void LogInfo(string message)
        {
            foreach (var writer in _logWriters)
            {
                writer.LogInfo(message);
            }
        }
        public void LogWarning(string message)
        {
            foreach (var writer in _logWriters)
            {
                writer.LogWarning(message);
            }
        }
        public void LogError(string message)
        {
            foreach (var writer in _logWriters)
            {
                writer.LogError(message);
            }

        }
    }
}