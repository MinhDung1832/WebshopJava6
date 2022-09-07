using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection_Lifetime.IServices;

namespace NET105_Tutorial_DI_DepedencyInjection_Lifetime.Controllers
{
    public class DungnaController : Controller
    {
        private ITransientService _transientService1;
        private ITransientService _transientService2; 
        private IScopedService _scopedService1;
        private IScopedService _scopedService2;  
        private ISingletonService _singletonService1;
        private ISingletonService _singletonService2;

        public DungnaController(ITransientService transientService1, ITransientService transientService2, IScopedService scopedService1, IScopedService scopedService2, ISingletonService singletonService1, ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }
        public IActionResult Index()
        {
            ViewBag.message1 = "First Instance: " + _transientService1.GetId().ToString();
            ViewBag.message2 = "Second Instance: " + _transientService2.GetId().ToString();

            ViewBag.message3 = "First Instance: " + _scopedService1.GetId().ToString();
            ViewBag.message4 = "Second Instance: " + _scopedService2.GetId().ToString();

            ViewBag.message5 = "First Instance: " + _singletonService1.GetId().ToString();
            ViewBag.message6 = "Second Instance: " + _singletonService2.GetId().ToString();
            return View();
        }
    }
}
