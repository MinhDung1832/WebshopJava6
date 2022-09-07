using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_POLY_CHSARP5.Data.EF.Entities
{
    public class FProduct
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }

        public List<FProductInCategory> ProductInCategories { get; set; }

        public List<FOrderDetail> OrderDetails { get; set; }
    }
}
