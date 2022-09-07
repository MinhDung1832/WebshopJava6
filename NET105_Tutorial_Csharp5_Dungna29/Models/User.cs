using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models
{
    public class User
    {
        public int UserId { get; set; }         //Entity Framework quy ước tên khóa chính của bảng có thể ở hai dạng: Id, và <Tên class>Id
                                                
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


        public int CountryId { set; get; }     // thêm thuộc tính (nullable) int? hoặc int
        public Country Country { set; get; }   // Thuộc tính tạo ra FK

    }
}
