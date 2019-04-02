using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Place
    {
        [Required]
        public int id { get; set; }
        public String name { get; set; }
        public int postalCode { get; set; }
    }
}