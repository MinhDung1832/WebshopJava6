using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection_Lifetime.IServices;

namespace NET105_Tutorial_DI_DepedencyInjection_Lifetime.Services
{
    public class DungnaService:ITransientService,ISingletonService,IScopedService
    {
        private Guid _guid;//Khởi tạo 1 biến kiểu dữ liệu Guild

        public DungnaService()
        {
            _guid = Guid.NewGuid();//Mỗi lần Class này được khởi tạo thì nó sẽ tạo ra 1 cái ID mới theo kiểu GUILD
        }

        public Guid GetId()
        {
            return _guid;
        }
        
    }
}
