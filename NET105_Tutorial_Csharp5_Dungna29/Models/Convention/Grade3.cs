using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.Convention
{
    public class Grade3
    {
        public int Grade3Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student3> Student3s { get; set; }
    }
}
