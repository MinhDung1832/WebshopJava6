using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.Convention
{
    public class Grade4
    {
        public int Grade4Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student4> Student4s { get; set; }
    }
}
