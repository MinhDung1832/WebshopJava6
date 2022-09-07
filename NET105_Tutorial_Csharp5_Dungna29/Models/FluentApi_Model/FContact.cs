using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model.Enums;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model
{
    public class FContact
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
