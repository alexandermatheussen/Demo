using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Field
    {
        [Required]
        public int id { get; set; }
        public FieldType fieldType { get; set; }
        public int position { get; set; }
        public Boolean required { get; set; }
        
        //public int positionRow { get; set; }        Optional solution for 2D positioning
        //public int positionColumn { get; set; }     of a field
    }
}