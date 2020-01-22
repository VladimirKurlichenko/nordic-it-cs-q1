using System.Collections.Generic;

namespace DocumentBD
{
    class Contractor
    {
        public Contractor(string fullName, Address address, string position)
        {
            FullName = fullName;
            Address = address;
            Position = position;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public Address Address { get; private set; }
        public string Position { get; private set; }

        public ICollection<DocumentStatus> DocumentsSender { get; private set; }
        public ICollection<DocumentStatus> DocumentsReceiver { get; private set; }
    }
}
