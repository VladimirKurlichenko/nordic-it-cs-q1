using System;

namespace ConsoleApp1
{
    public class RandomDateGenerator
    {
        public event EventHandler<RandomDateGeneratedHandler> RandomDateGeneratedHandler;
        public event EventHandler RandomDateGenereted;


        public byte[] GetRandomDate (int dateSize, int bytesDoneraiseEvent)
        {
            if(dateSize <= 0)
            {
                throw new ArgumentException(nameof(dateSize));
            }
            if (bytesDoneraiseEvent <= 0)
            {
                throw new ArgumentException(nameof(bytesDoneraiseEvent));
            }
            var byteM = new byte[dateSize];
            Random random = new Random();
            for (int i = 0; i < byteM.Length; i++)
            {
                int index = i;
                byteM[i] = (byte)random.Next();
                if ((i+1) % bytesDoneraiseEvent == 0)
                {
                    RandomDateGeneratedHandler?.Invoke(this, new RandomDateGeneratedHandler(i, dateSize));
                }
            }

            RandomDateGenereted?.Invoke(this, null);
            return byteM;
        }
    }
}
