using System.IO;

namespace LogWriter2
{
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        private readonly string _path;

        public FileLogWriter(string path)
        {
            _path = path;
        }
        protected override void WriteMessage(string line) =>
            File.AppendAllText(_path, line);
    }
}
