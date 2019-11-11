using System;
using System.IO;

namespace SinglLogWriter
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly ILogWriter[] _logWriters;
        private static MultipleLogWriter instance;
        private MultipleLogWriter(params ILogWriter[] writer)
        {
            _logWriters = writer;
        }
        public static MultipleLogWriter GetInstance(params ILogWriter[] _logwriters)
        {
            return instance ??
                (instance = new MultipleLogWriter(_logwriters));
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