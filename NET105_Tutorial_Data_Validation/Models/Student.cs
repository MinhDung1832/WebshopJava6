using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Data_Validation.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Id Sinh Viên: ")]//Hiển thị tên trên website
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = "Hãy nhập tên vào đi bạn ơi")]
        [StringLength(20,MinimumLength = 3,ErrorMessage = "Dài nhất 20 ít nhất là 3")]
        [RegularExpression(pattern: "^Mr\\..*|^Mrs\\..*|^Ms\\..*|^Miss\\..*", ErrorMessage = "Tên phải bắt đầu với Mr./Mrs./Ms./Miss.")]
        public string StudentName { get; set; }

        [Required]
        [Range(18,40,ErrorMessage = "Tuổi trong khoảng 18  đến 40 nhé")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Định dạng mail bạn nhé")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Vui lòng điền số nhé")]
        [RegularExpression(pattern: "(84|0[3|5|7|8|9])+([0-9]{8})\\b", ErrorMessage = "Số điện thoại kiểu viện nam nhé!")]
        public int Phone { get; set; }

        [CreditCard(ErrorMessage = "Bạn nhập đủ 16 số thẻ chưa đúng định dạng")]
        [DataType(DataType.CreditCard)]
        public string CreditCard { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 6,ErrorMessage = "Độ dài mật khẩu không hợp lệ")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu không hợp lệ")]
        [Compare(otherProperty: "NewPassword",ErrorMessage = "Không khớp với mật khẩu trên")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Url(ErrorMessage = "Đường dẫn không hợp lệ")]
        public string UrlFacebook { get; set; }

        // [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
    }
}
