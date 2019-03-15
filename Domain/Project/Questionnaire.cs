using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Questionnaire
    {
        [Required]
        public int id { get; set; }
        
        public string name { get; set; }
        public int questionAmount { get; set; }
        public Boolean confirmed { get; set; }
        public Project project { get; set; }
        public ICollection<Question> questions { get; set; }
        public ICollection<IotSetup> iotSetups { get; set; } // Moet een vraag apart niet verbonden worden met iot opstelling?
                                                             // anders weet je toch niet aan welke vraag de opstelling hangt
        //public User user { get; set; }

        public Questionnaire()
        {
        }

        public Questionnaire(int id, int questionAmount, ICollection<Question> questions)
        {
            this.id = id;
            this.questionAmount = questionAmount;
            this.questions = questions;
        }
    }
}