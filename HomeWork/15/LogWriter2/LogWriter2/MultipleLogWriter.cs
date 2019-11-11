namespace LogWriter2
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly ILogWriter[] _logWriters;

        public MultipleLogWriter(params ILogWriter[] writer)
        {
            _logWriters = writer;
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
