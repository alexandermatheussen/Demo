using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String firstName { get; set; }
        [Required]
        public String lastName { get; set; }
        [Required]
        public String eMailAddress { get; set; }
        [Required]
        public String password { get; set; }
        public Gender gender { get; set; }
        [Required]
        public int age { get; set; }
        public Boolean verified { get; set; }
        public Address address { get; set; }
        public IEnumerable<QuestionUser> questionnaireAnswer { get; set; }
        //public Questionnaire questionnaire { get; set; }
        public ICollection<Idea> ideas { get; set; }
        public ICollection<Answer> answers { get; set; }
    }
}