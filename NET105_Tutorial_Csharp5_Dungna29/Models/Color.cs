using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models
{
    [Table("Color")]
    public class Color
    {
        [Key]                                  // Là Primary key
        public int ColortId { set; get; }

        [Required]                             // Cột trong DB, Not Null
        [StringLength(50)]                     // nvarchar(50)
        public string Name { set; get; }
    }
}
