﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoCristian.Areas.Login.Controllers
{
    [Area("Login")]
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
