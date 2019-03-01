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
        public IEnumerable<IotSetup> iotSetups { get; set; }
        public User user { get; set; }
    }
}