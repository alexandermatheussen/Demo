using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Idea
    {
        [Required]     
        public int id { get; set; }
        public IEnumerable<Answer> answers { get; set; }
        public String name { get; set; }
        public int like { get; set; }
        public int share { get; set; }
    }
}