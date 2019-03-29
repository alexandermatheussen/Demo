using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Required]     
        public int id { get; set; }
        public string FirstName { get; set; }
    }
}