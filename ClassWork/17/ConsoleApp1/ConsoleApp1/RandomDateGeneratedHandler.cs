namespace ConsoleApp1
{
    public class RandomDateGeneratedHandler
    {
        public RandomDateGeneratedHandler(int dateDone, int totalBytes)
        {
            DateDone = dateDone;
            TotalBytes = totalBytes;
        }

        public int DateDone { get; }
        public int TotalBytes { get; }
    }
}
