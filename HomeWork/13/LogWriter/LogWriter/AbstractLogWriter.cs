using System;

namespace LogWriter
{

    abstract class AbstractLogWriter : ILogWriter
    {
        public virtual string Description(string messageType) =>
            $"{DateTime.Now}      {messageType}";
        public abstract void LogInfo(string message);
        public abstract void LogWarning(string message);
        public abstract void LogError(string message);

    }
}
