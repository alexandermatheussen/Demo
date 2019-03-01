using System;
using System.Collections.Generic;

namespace Domain
{
    public class Vragenlijst
    {
        public String naam { get; set; }
        public ICollection<Vraag> vragen { get; set; }

    }
}