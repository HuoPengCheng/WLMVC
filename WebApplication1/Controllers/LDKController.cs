﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LDKController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            ViewBag.pid = id;
            return View();
        }
    }
}
