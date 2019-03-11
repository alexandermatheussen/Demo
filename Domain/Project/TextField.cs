using System;

namespace Domain
{
    public class TextField : Field
    {
            public String content { get; set; }
            public int maxCharacters { get; set; }
    }
}