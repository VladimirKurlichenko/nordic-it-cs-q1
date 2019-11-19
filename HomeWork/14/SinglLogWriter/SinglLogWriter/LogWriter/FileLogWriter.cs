using System;
using System.IO;

namespace SinglLogWriter
{
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        private static string _path = "log.txt";

        private static FileLogWriter _instance;
        public static FileLogWriter GetInstance
        {
            get
            {
                return _instance ??
               (_instance = new FileLogWriter());
            }
        }

        public static string Path 
        {
            get { return _path; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _path = value;
            }
        }

        private static string _WriterPath()
        {
            Console.Write("Enter path file: ");
            return Console.ReadLine();
        }
        protected override void WriteMessage(string line) =>
            File.AppendAllText(Path, line);
    }
}

