﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class Employee_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
