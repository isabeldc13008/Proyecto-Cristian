using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoCristian.Areas.Producto.Models;
using ProyectoCristian.Data;

namespace ProyectoCristian.Areas.Login.Controllers
{
    [Area("Login")]
    public class Login : Controller
    {
        public ApplicationDbContext db { set; get; }
        Usuario usu = new Usuario();

        public Login(ApplicationDbContext a) {
            db = a;
        }
        public IActionResult Index()
        {
            usu.usuarios = db.usuarios.ToList();
            return View(usu);
        }

        public IActionResult   Inicio(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            List<Usuario> usu = db.usuarios.ToList();
            Usuario busqueda = usu.Find(e => e.correo == usuario.correo && e.clave == usuario.clave);
            if (busqueda == null)
            {
                return RedirectToAction("Index");
            }
            if (busqueda.rol == 1)
            {
                string id =busqueda.id_usuario.ToString();
               
                HttpContext.Session.SetString("idusuario", id);
                return RedirectToAction("Index", "Usuarios", new { @area="Usuarios"});
                
              
            }
            else if (busqueda.rol == 2)
            {
                return RedirectToAction("Index", "Producto", new { @area="Producto"});
            }
            return RedirectToAction("Index");
        }
    }
}
