using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CentralQuestion
    {
        [Required]     
        public int id { get; set; }
        public String question { get; set; }
        public ICollection<Idea> ideas { get; set; }
        public int like { get; set; }
        
        
    }
}