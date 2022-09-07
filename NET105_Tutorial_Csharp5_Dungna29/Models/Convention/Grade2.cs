using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.Convention
{
    public class Grade2
    {
        public int Grade2Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student2> Student2s { get; set; }
    }
}
