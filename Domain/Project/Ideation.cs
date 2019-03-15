using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Ideation
    {
        [Required]     
        public int ideationId { get; set; }     
        public Project project { get; set; }
        public Boolean adminOnly { get; set; }
        public ICollection<IdeationQuestion> questions { get; set; }
        public ICollection<Idea> ideas { get; set; }
        
        public IEnumerable<IotSetup> iotSetups { get; set; }
    }

}