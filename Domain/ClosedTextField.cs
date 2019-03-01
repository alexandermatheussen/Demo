using System;
using System.Collections.Generic;

namespace Domain
{
    public class ClosedTextField : Field
    {
        public Boolean multipleChoice { get; set; }
        public String question { get; set; }
        public IEnumerable<String> options { get; set; }
    }
}