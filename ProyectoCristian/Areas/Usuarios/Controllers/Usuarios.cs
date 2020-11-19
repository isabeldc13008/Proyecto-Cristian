using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoCristian.Areas.Producto.Models;
using ProyectoCristian.Data;

namespace ProyectoCristian.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class Usuarios : Controller
    {
        public ApplicationDbContext db { get; set; }
        Usuario usu = new Usuario();
        Productos p = new Productos();
        public Usuarios(ApplicationDbContext a) {
            db = a;
        }
        public IActionResult Index() {
            return View();
        }
        public IActionResult Productos() {
            p.producto = db.productos.ToList();
            return View(p);
        }

        public IActionResult Carrito()
        {
            return View();
        }

       
        
    }

}
