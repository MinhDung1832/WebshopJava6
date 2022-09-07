using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model
{
    public class FProductInCategory
    {
        public int ProductId { get; set; }

        public FProduct Product { get; set; }

        public int CategoryId { get; set; }

        public FCategory Category { get; set; }
    }
}
