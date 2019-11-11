using System;
using System.IO;

namespace SinglLogWriter
{
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        private readonly string _path; 
        private static FileLogWriter instance;
        private FileLogWriter(string path)
        {
            _path = path;
        }
        public static FileLogWriter GetInstance(string path)
        {
            return instance ??
                (instance = new FileLogWriter(path));
        }


        protected override void WriteMessage(string line) =>
            File.AppendAllText(_path, line);
    }
}

