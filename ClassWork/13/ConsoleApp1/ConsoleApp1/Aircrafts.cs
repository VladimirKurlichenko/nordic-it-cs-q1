namespace ConsoleApp1
{
    abstract class Aircrafts : IUpper, ILower, IWrite
    {
        public int MaxHeight { get; private set; }
        public  int CurrentHeight { get; private set; }

        protected Aircrafts(int maxHeight,int currentHeight=200)
        {
            MaxHeight = maxHeight;
            CurrentHeight = currentHeight;
        }

        public void TakeUpper(int delta)
        {
            if(delta <= 0)
            {
                throw new System.ArgumentOutOfRangeException("WOW");
            }
            if (delta + CurrentHeight > MaxHeight)
            {
                MaxHeight = delta + CurrentHeight;
            }
            else
                CurrentHeight = CurrentHeight + delta;
        }
        public void TakeLower(int delta)
        {
            if (delta <= 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            if (CurrentHeight - delta > 0)
            {
                CurrentHeight = CurrentHeight - delta;
            }
            if(CurrentHeight-delta == 0)
            {
                CurrentHeight = 0;
            }
            if (CurrentHeight - delta < 0)
            {
                throw new System.InvalidOperationException("Crach!");
            }

        }

        public abstract void WriteProperties();
    }
}
