using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HPCController1 : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
