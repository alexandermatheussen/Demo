using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.Extensions.Primitives;

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
        public int unconfirmedLikes { get; set; }
        public Place place { get; set; }
        public IEnumerable<Ideation> ideations { get; set; }
        public IEnumerable<Questionnaire> questionnaires { get; set; }
        public IEnumerable<Fase> fases { get; set; }
    }
}    