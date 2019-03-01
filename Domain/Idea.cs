using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Idea
    {
        [Required]     
        public int id { get; set; }
        public ICollection<Answer> answers { get; set; }
        
    }
}