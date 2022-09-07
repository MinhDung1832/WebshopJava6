using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models
{
    [Table("Product")]                     // Ánh xạ bảng Product 
    public class Product
    {
        [Key]                                  // Là Primary key
        public int ProductId { set; get; }

        [Required]                             // Cột trong DB, Not Null
        [StringLength(50)]                     // nvarchar(50)
        public string Name { set; get; }

        [Column(TypeName = "Money")]           // cột kiểu Money trong SQL Server (tương ứng decimal trong Model C#)
        public decimal Price { set; get; }

        [ForeignKey("CategoryID")]          //Đăt tên FK tùy chọn
        public Category Category { set; get; }  //FK1
        
        [ForeignKey("CountryID")]           //Đăt tên FK tùy chọn
        public Country Country { set; get; }    //FK2

        [Required] // hoặc thêm [Required] khi vẫn dùng int?
        public int ColorId { set; get; }     // thêm thuộc tính (nullable) int? hoặc int
        public Color Color { set; get; }   // Thuộc tính tạo ra FK

    }
}
