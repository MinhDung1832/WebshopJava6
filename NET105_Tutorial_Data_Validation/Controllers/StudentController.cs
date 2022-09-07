using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_Data_Validation.Models;

namespace NET105_Tutorial_Data_Validation.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public string CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                return "Tạo thành công";
            }

            return "Tạo thất bại";
        }
    }
}
