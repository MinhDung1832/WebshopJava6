using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_POLY_CHSARP5.Data.EF.Entities
{
    public class FOrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public FOrder Order { get; set; }

        public FProduct Product { get; set; }
    }
}
