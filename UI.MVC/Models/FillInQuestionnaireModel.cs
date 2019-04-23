using System.Collections.Generic;
using Domain;

namespace D.UI.MVC.Models
{
    public class FillInQuestionnaireModel
    {
        public IEnumerable<Question> questions { get; set; }
        public Questionnaire questionnaire { get; set; }
    }
}