using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT_POLY_CHSARP5.Data.EF.Entities.Enums;

namespace FPT_POLY_CHSARP5.Data.EF.Entities
{
    public class FCategory
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }

        public List<FProductInCategory> ProductInCategories { get; set; }
    }
}
