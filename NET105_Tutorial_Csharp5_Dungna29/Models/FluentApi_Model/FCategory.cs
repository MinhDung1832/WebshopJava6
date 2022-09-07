using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model.Enums;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model
{
    public class FCategory
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }

        public List<FProductInCategory> ProductInCategories { get; set; }

        public List<FCategoryTranslation> CategoryTranslations { get; set; }
    }
}
