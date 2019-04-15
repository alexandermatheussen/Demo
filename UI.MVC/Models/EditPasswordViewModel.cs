using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace D.UI.MVC.Models
{
    public class EditPasswordViewModel
    {
        [Required]
        public String oldPassword { get; set; }
        [Required]
        public String newPassword { get; set; }
        [Required]
        public String newConfirmedPassword { get; set; }
    }
}