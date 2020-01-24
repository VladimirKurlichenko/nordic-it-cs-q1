using System.Collections.Generic;

namespace DocumentBD
{
    class Contractor
    {
        public Contractor()
        {
                
        }
        public Contractor(string fullName, Address addressCompany, string position)
        {
            AddressCompany = addressCompany;
            Position = position;
            NewFullName = fullName;

        }

        public int Id { get; private set; }
        public string NewFullName { get; private set; }
        public Address AddressCompany { get; private set; }
        public string Position { get; private set; }

        public ICollection<DocumentStatus> DocumentsSender { get; private set; }
        public ICollection<DocumentStatus> DocumentsReceiver { get; private set; }
    }
}
