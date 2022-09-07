using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_Csharp5_Dungna29.Models
{
    public class SinhVien
    {
        [Display(Name = "Id Sinh Viên:")]
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Hãy nhập tên vào đi bạn ơi")]
        [StringLength(20,MinimumLength = 4,ErrorMessage = "Dài nhất 20 tối bé nhất 4")]
        //[MaxLength(20,ErrorMessage = "Độ dài của tên cần ")]
        [Display(Name = "Tên Sinh Viên:")]
        [RegularExpression(pattern: "^Mr\\..*|^Mrs\\..*|^Ms\\..*|^Miss\\..*", ErrorMessage = "Name must start with Mr./Mrs./Ms./Miss.")]
        public string StudentName { get; set; }

        [Required]
        [Range(10, 20,ErrorMessage = "Tuổi trong khoảng 10 đến 20 nhé")]//Chỉ được trong khoảng 10 đến 20
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Định dạng mail bạn nhé")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Bạn ơi điền số má vào điền chữ thế à")]
        public int Phone { get; set; }

        [CreditCard(ErrorMessage = "Please enter a valid card No")]
        public string creditCard { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Hãy nhập vào password")]
        public string NewPassword { get; set; }

        [Compare(otherProperty: "NewPassword", ErrorMessage = "Không khớp với cái vừa nhập rồi")]
        public string ConfirmPassword { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL")]
        public string UrlFacebook { get; set; }

        [Required(ErrorMessage = "Please choose date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
    }
}
