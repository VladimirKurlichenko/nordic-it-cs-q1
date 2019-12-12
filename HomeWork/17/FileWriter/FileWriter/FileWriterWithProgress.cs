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
            if (fileName == default)
            {
                throw new ArgumentException(nameof(fileName));
            }
            if (data.Length == 0)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (percentageToFireEvent <= 0 && percentageToFireEvent >= 1)
            {
                throw new ArgumentException(nameof(percentageToFireEvent));
            }

            using var fileStream = File.OpenWrite(fileName);
            float percentage = percentageToFireEvent;
            for (int i = 0; i < data.Length; i++)
            {
                fileStream.WriteByte(data[i]);
                if (percentage < ((float)(i + 1) / (float)data.Length))
                {
                    EventWritingPerformed?.Invoke(this, new WritingPerformed(percentage));

                    percentage += percentageToFireEvent *
                        ((float)Math.Floor((((float)(i + 1) / (float)data.Length) - percentage) / percentageToFireEvent) + 1);

                }
            }
            EventWritingCompleted?.Invoke(this, null);
        }
    }
}
