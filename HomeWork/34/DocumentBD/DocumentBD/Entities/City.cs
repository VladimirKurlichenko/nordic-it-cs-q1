using System.Collections.Generic;

namespace DocumentBD
{
    class City
    {
        public City(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public ICollection<Address> Addresses { get; private set; }
}
}
