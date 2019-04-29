using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Report
    {
        public int id { get; set; }
        [MaxLength(255)]
        public string reportMessage { get; set; }
        public DateTime dateSubmitted { get; set; }
        public Idea idea { get; set; }
        //public User user { get; set; }
    }
}