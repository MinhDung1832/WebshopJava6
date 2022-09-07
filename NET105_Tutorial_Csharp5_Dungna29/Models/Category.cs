using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { set; get; }

        [StringLength(100)]
        public string Name { set; get; }

        [Column(TypeName = "nvarchar")]                  // Cột (trường) kiểu nvarchar trong SQL Server
        [StringLength(255)]
        public string Description { set; get; }
    }
}
