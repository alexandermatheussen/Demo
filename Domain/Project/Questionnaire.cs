using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Questionnaire
    {
        [Required]
        public int id { get; set; }
        public int questionAmount { get; set; }
        public Boolean confirmed { get; set; }
        public IEnumerable<Question> questions { get; set; }
        public IEnumerable<IotSetup> iotSetups { get; set; } // Moet een vraag apart niet verbonden worden met iot opstelling?
                                                             // anders weet je toch niet aan welke vraag de opstelling hangt
        //public User user { get; set; }
    }
}