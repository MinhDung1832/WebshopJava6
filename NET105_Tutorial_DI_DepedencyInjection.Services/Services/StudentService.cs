using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection.Services.Dtos;
using NET105_Tutorial_DI_DepedencyInjection.Services.IServices;

namespace NET105_Tutorial_DI_DepedencyInjection.Services.Services
{
    public class StudentService: IStudentService
    {
        //Các chức năng CRUD cho đối tượng
        public List<StudentModel> GetAllStudentsModels()
        {
            return new List<StudentModel>
            {
                new StudentModel{Id = 1,Msv = "PH000555",Ten = "Nguyễn Anh A"},
                new StudentModel{Id = 2,Msv = "PH000556",Ten = "Nguyễn Anh B"},
                new StudentModel{Id = 3,Msv = "PH000557",Ten = "Nguyễn Anh C"},
                new StudentModel{Id = 4,Msv = "PH000558",Ten = "Nguyễn Anh D"},
                new StudentModel{Id = 5,Msv = "PH000559",Ten = "Nguyễn Anh E"}
            };
        }
    }
}
