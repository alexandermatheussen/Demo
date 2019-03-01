using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Fase
    {
        [Required]     
        public int id { get; set; }
        
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        
    }
}