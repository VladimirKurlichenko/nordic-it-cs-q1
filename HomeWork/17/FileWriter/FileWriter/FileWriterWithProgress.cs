using System;
using System.IO;

namespace FileWriter
{
    public class FileWriterWithProgress
    {
        public event EventHandler<WritingPerformed> EventWritingPerformed;
        public event EventHandler EventWritingCompleted;

        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            float percentage = default;
            for (int i = 0; i < data.Length; i++)
            {
                if (fileName == default)
                {
                    throw new ArgumentException(nameof(fileName));
                }
                if(data.Length == 0)
                {
                    throw new ArgumentNullException(nameof(data));
                }
                if (percentageToFireEvent <= 0 && percentageToFireEvent >= 1)
                {
                    throw new ArgumentException(nameof(percentageToFireEvent));
                }
                File.AppendAllText(fileName, String.Join(",", data[i]));
                if ((i/ data.Length) % percentageToFireEvent == 0 && (i + 1) * percentageToFireEvent <= 1)
                {
                    percentage = (i + 1) * percentageToFireEvent * 100;
                    EventWritingPerformed?.Invoke(this, new WritingPerformed(percentage));
                }
            }
            EventWritingCompleted?.Invoke(this, null);
        }
    }
}
