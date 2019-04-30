using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Project
    {
        [Required]     
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int confirmedLikes { get; set; }
        public int unConfirmedLikes { get; set; }
        public Place place { get; set; }
        public ICollection<Ideation> ideations { get; set; }
        public ICollection<Questionnaire> questionnaires { get; set; }
        public ICollection<Phase> phases { get; set; }
    }
}