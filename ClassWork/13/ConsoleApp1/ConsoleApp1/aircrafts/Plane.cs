namespace ConsoleApp1
{
    class Plane : Aircrafts, IWrite
    {
        public byte EnginesCount { get; set; }
        public Plane(int maxHeight, byte enginesCount) : base(maxHeight)
        {
            System.Console.WriteLine("It's a plane, welcome aboard!");
            EnginesCount = enginesCount;
            
        }
        public override void WriteProperties()
        {
            System.Console.WriteLine($"EnginesCount: {EnginesCount},MaxHeight: {MaxHeight},CurrentHeight: {CurrentHeight}");
        }
    }
}
