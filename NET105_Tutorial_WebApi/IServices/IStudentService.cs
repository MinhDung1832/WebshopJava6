using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_WebApi.Models;

namespace NET105_Tutorial_WebApi.IServices
{
    public interface IStudentService
    {
        List<Student> GetLstStudents();

        Student GetStudent(Guid id);
        Student AddStudent(Student student);

        void DeleteStudent(Student student);
        Student EditStudent(Student student);
    }
}
