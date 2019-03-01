using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Domain
{
    public class Project
    {
        [Required]     
        public int id { get; set; }
        public String naam { get; set; }
        public String beschrijving { get; set; }
        
        public ICollection<Ideation> ideations { get; set; }
        public ICollection<Fase> fases { get; set; }


        public Project(int id, String naam, String beschrijving)
        {
            this.id = id;
            this.naam = naam;
            this.beschrijving = beschrijving;
        }

    }
}