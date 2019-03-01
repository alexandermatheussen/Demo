using System;
using System.Collections.Generic;

namespace Domain
{
    public class Ideation
    {
        public Boolean adminOnly { get; set; }
        public ICollection<CentraleVraag> vragen { get; set; }

    }

}