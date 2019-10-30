namespace ConsoleApp1
{
    class Helicopter : Aircrafts, IWrite
    {
        public byte BladesCount { get; set; }
        public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
        {
            System.Console.WriteLine("It's a helicoptor, welcome aboard!");
            BladesCount = bladesCount;
        }
        public override void WriteProperties()
        {
            System.Console.WriteLine($"BladesCount: {BladesCount},MaxHeight: {MaxHeight},CurrentHeight: {CurrentHeight}");
        }


    }
}
