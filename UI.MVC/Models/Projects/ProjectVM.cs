using System;
using System.Collections.Generic;
using Domain;

namespace D.UI.MVC.Models.Projects
{
    public class ProjectVM
    {
        public string name { get; set; }
        
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        
        public byte[] projectImage { get; set; }
        
        public ICollection<Phase> phases { get; set; }
        
        

       
    }
}