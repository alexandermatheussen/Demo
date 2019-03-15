using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain
{
    public class Answer
    {
        [Required]
        public  int answerId { get; set; }
        [Required]
        public Idea idea { get; set; }
        public User user { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
    }
}