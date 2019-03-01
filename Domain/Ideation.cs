using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Ideation
    {
        [Required]     
        public int id { get; set; }
        public Boolean adminOnly { get; set; }
        public IEnumerable<CentralQuestion> centralQuestions { get; set; }
        public IEnumerable<IotSetup> IotSetups { get; set; }
    }

}