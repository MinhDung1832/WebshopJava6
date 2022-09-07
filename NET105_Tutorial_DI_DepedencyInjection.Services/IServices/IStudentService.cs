using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection.Services.Dtos;

namespace NET105_Tutorial_DI_DepedencyInjection.Services.IServices
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudentsModels();
    }
}
