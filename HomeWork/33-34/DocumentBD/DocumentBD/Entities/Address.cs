

using System.Collections.Generic;

namespace DocumentBD
{
    class Address
    {
        public Address()
        {

        }
        public Address(string city, string addressCity)
        {
            City = city;
            AddressCity = addressCity;
        }

        public int Id { get; private set; }
        public string City { get; private set; }
        public string AddressCity { get; private set; }
        public ICollection<Contractor> Contractors { get; private set; }
    }
}
