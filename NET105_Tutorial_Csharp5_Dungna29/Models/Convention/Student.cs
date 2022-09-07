using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.Convention
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentAddress Address { get; set; }
    }
}
