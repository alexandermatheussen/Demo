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
        public String description { get; set; }
        public IEnumerable<Idea> ideas { get; set; }
        public int likeAmount { get; set; }
        public int shareAmount { get; set; }
        public String link { get; set; }
        //public IdeaTemplate ideaTemplate { get; set; }
    }
}