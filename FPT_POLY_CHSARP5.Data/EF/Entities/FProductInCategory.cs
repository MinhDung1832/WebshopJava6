using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_POLY_CHSARP5.Data.EF.Entities
{
    public class FProductInCategory
    {
        public int ProductId { get; set; }

        public FProduct Product { get; set; }

        public int CategoryId { get; set; }

        public FCategory Category { get; set; }
    }
}
