namespace LogWriter2
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string massage);
        void LogError(string message);
    }
}
