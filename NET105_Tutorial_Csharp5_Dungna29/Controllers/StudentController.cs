using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NET105_Tutorial_Csharp5_Dungna29.Models;

namespace NET105_Tutorial_Csharp5_Dungna29.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                return "Edit thành công";
               
            }
            return "Lỗi rồi";
        }
    }
}
