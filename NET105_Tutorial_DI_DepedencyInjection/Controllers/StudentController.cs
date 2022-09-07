using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection.Services.IServices;
using NET105_Tutorial_DI_DepedencyInjection.Services.Services;

namespace NET105_Tutorial_DI_DepedencyInjection.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        
        public StudentController(IStudentService studentService)
        {
            //DI sẽ giúp tự động truyền vào studentService và gán lại cho _studentService sẽ giúp chúng ta chỉ việc lấy về và gán vào biến cho chúng ta ko cần khởi tạo nữa
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var getAll = _studentService.GetAllStudentsModels();
        
            return View(getAll);
        }
      
    }
}
