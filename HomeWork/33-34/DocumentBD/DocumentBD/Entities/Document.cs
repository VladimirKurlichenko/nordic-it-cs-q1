﻿using System.Collections.Generic;

namespace DocumentBD
{
    class Document
    {
        public Document()
        {

        }
        public Document(string type, string name, int pages)
        {
            Type = type;
            Name = name;
            Pages = pages;
        }

        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Name { get; private set; }
        public int Pages { get; private set; }

        public ICollection<DocumentStatus> Documents { get; private set; }
    }
}
