using System.Collections.Generic;
using Domain;

namespace D.UI.MVC.Models
{
    public class IdeaAndAnswers
    {
        public IEnumerable<Answer> answers { get; set; }
        public Idea idea { get; set; }
        
        public IEnumerable<IdeationQuestion> ideationQuestions { get; set; }
    }
}