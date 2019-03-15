using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain
{
    public class Question
    {
        [Required]
        public int id { get; set; }
        public QuestionType questionType { get; set; }
        public String question { get; set; }
        public Questionnaire questionnaire { get; set; }
        public IEnumerable<Option> options { get; set; }

        public Question()
        {
        }

        public Question(string question)
        {
            this.question = question;
        }
    }
}