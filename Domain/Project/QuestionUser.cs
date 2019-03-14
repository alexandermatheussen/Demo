using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class QuestionUser
    {
        [Required]
        public int id { get; set; }
        public Question question { get; set; }
        public User user { get; set; }
    }
}