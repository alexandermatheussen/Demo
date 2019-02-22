using System;
using System.Collections.Generic;

namespace Domain
{
    public class CentraleVraag
    {
        public int id { get; set; }
        public String vraag { get; set; }
        public ICollection<Idee> ideeën { get; set; }
        public String xxx { get; set; }
        
        
    }
}