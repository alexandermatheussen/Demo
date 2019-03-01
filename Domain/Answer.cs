using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain
{
    public class Answer
    {
        
        [Required]
        public  int id { get; set; }
    }
}