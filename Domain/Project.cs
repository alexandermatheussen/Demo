using System;
using System.Collections.Generic;
using System.Globalization;

namespace Domain
{
    public class Project
    {
        public int id { get; set; }
        public String naam { get; set; }
        public String beschrijving { get; set; }
        
        public ICollection<Ideation> ideations { get; set; }
        public ICollection<Fase> fases { get; set; }
        

    }
}