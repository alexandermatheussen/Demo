using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Required]     
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String eMailAddress { get; set; }
        public String password { get; set; }
        public Gender gender { get; set; }
        public int age { get; set; }
        public Boolean verified { get; set; }
        public String postalCode { get; set; }
        //public Questionnaire questionnaire { get; set; }
        public IEnumerable<Answer> answers { get; set; }
        public IEnumerable<Idea> ideas { get; set; }
    }
}