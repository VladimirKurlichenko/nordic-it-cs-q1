﻿using System;
using System.IO;

namespace LogWriter
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
