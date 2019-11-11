namespace ConsoleApp1
{
    class Account<T, TS>
    {
        public T Id { get; private set; }
        public TS Name { get; private set; }

        public Account(T id, TS name)
        {
            Id = id;
            Name = name;
        }

        public void WriteProperties() => 
            System.Console.WriteLine($"{Id}: {Name}");
    }
}
