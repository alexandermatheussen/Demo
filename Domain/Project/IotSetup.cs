using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class IotSetup
    {
        [Required]
        public int id { get; set; }
        public Address address { get; set; }
        public Questionnaire questionnaire { get; set; }
    }
}