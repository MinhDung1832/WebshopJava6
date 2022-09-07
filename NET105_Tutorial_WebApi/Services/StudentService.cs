using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_WebApi.IServices;
using NET105_Tutorial_WebApi.Models;

namespace NET105_Tutorial_WebApi.Services
{
    public class StudentService :IStudentService
    {
        private List<Student> _lstStudents = new List<Student>()
        {
            new Student {Id = Guid.NewGuid(), Msv = "PH00532", NamSinh = 2000, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00533", NamSinh = 2001, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00534", NamSinh = 2002, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00535", NamSinh = 2002, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00536", NamSinh = 2002, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00537", NamSinh = 2002, NganhHoc = "UDPM"},
            new Student {Id = Guid.NewGuid(), Msv = "PH00538", NamSinh = 2002, NganhHoc = "UDPM"}
        };
        public List<Student> GetLstStudents()
        {
            return _lstStudents;
        }

        public Student GetStudent(Guid id)
        {
            return _lstStudents.Where(c => c.Id == id).FirstOrDefault();
        }

        public Student AddStudent(Student student)
        {
            student.Id = Guid.NewGuid();
            _lstStudents.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _lstStudents.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            var temp = GetStudent(student.Id);
            temp.Msv = student.Msv;
            return student;
        }
    }
}
