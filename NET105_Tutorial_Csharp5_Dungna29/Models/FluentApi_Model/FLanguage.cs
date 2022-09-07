using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model
{
    public class FLanguage
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<FProductTranslation> ProductTranslations { get; set; }

        public List<FCategoryTranslation> CategoryTranslations { get; set; }
    }
}
