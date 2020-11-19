using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoCristian.Areas.Productos.Controllers
{
    [Area("Productos")]
    public class Productos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Producto() {
            return View();
        }
        public IActionResult Carrito() {
            return View();
        }
       
    }
}
