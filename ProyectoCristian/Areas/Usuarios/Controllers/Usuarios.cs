using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoCristian.Areas.Producto.Models;
using ProyectoCristian.Areas.Usuarios.Models;
using ProyectoCristian.Data;

namespace ProyectoCristian.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class Usuarios : Controller
    {
        public ApplicationDbContext db { get; set; }
        Usuario usu = new Usuario();
        Productos p = new Productos();

        public Usuarios(ApplicationDbContext a)
        {
            db = a;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Productos()
        {
            p.producto = db.productos.ToList();
            return View(p);
        }

        public IActionResult Carrito()
        {
            return View();
        }

        public IActionResult guardar(CompraUsuario e)
        {
    
            string valor = HttpContext.Session.GetString("idusuario");
            int usuario = int.Parse(valor);
            DateTime fecha = DateTime.Now;
            Compras compra = new Compras { Id_usuario = usuario, fecha = fecha, valor = e.total, cantidad = e.cantidad };

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Add(compra);
                    db.SaveChanges();
                    foreach (Productos t in e.Productos) {
                        DetalleCompra j = new DetalleCompra
                        {
                            id_producto = t.id_productos,
                            id_compra = compra.Id_compra
                        };
                        db.Add(j);
                        
                    }
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception a)
                {
                    transaction.Rollback();
                }
            }
            return RedirectToAction("Index");

        } 
            
            

            
    }


}


