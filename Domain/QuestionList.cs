using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class QuestionList
    {
        [Required]     
        public int id { get; set; }
        public String name { get; set; }
        public ICollection<Question> questions { get; set; }

    }
}