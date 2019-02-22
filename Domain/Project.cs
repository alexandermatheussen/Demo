using System;
using System.Collections.Generic;

namespace Domain
{
    public class Project
    {
        public String naam { get; set; }
        public String beschrijving { get; set; }
        
        public ICollection<CentraleVraag> vragen { get; set; }
        public ICollection<Fase> fases { get; set; }
        

    }
}