using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult SayHello()
        {
            //implement code here
            return View();
        }
    }
}