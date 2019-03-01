using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Required]     
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String emailAddress { get; set; }
        public String password { get; set; }
        public Gender gender { get; set; }
        public int age { get; set; }
        public Boolean verified { get; set; }
        public String postalCode { get; set; }
    }
}