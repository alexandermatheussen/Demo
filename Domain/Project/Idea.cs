using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Idea
    {
        [Required]     
        public int ideaId { get; set; }
        public User user { get; set; }
        public Ideation ideation { get; set; }
      
        public string title { get; set; }
        public string content { get; set; }
         
        public ICollection<Answer> answers { get; set; }
    }
}