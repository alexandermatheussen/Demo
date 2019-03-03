using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IdeaTemplate
    {
        [Required]
        public int id { get; set; }
        public String name { get; set; }
        public IEnumerable<Idea> ideas { get; set; }
        public IEnumerable<Field> fields { get; set; }
        //public CentralQuestion centralQuestion { get; set; }
    }
}