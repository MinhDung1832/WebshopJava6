using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NET105_Tutorial_WebApi.IServices;
using NET105_Tutorial_WebApi.Models;

namespace NET105_Tutorial_WebApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
       
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetStudents()
        {
            return Ok(_studentService.GetLstStudents());
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public IActionResult GetStudent(Guid id)
        {
            var temp = _studentService.GetStudent(id);
            if (temp != null)
            {
                return Ok(_studentService.GetStudent(id));
            }
        
            return NotFound($"Sinh viên với ID: {id} không tìm thấy");
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult GetStudent(Student student)
        {
            _studentService.AddStudent(student);
            return Created(
                HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path +
                student.Id, student);
        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var temp = _studentService.GetStudent(id);
            if (temp != null)
            {
                _studentService.DeleteStudent(temp);
                return Ok("Xóa thành công");
            }

            return NotFound($"Sinh viên với ID: {id} không tìm thấy");
        }

        [HttpPatch]
        [Route("[controller]/{id}")]
        public IActionResult EdiStudent(Guid id,Student student)
        {
            var temp = _studentService.GetStudent(id);
            if (temp != null)
            {
                student.Id = temp.Id;
                _studentService.EditStudent(student);
            }

            return Ok(student + " Sửa thành công");
        }
    }
}
