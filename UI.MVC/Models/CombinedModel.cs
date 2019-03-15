using System.Collections.Generic;
using Domain;

namespace D.UI.MVC.Models
{
    public class CombinedModel
    {
        public QuestionUser questionUser { get; set; }
        public IEnumerable<Question> questions { get; set; }
    }
}