using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoCristian.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class Usuarios : Controller
    {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Productos() {
            return View();
        }

        public IActionResult Carrito()
        {
            return View();
        }
    }

}
