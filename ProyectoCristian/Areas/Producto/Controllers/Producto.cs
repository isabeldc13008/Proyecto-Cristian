using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoCristian.Areas.Producto.Models;
using ProyectoCristian.Data;
using ProyectoCristian.Models.Paginador;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProyectoCristian.Areas.Producto.Controllers
{
    [Area("Producto")]
    public class Producto : Controller
    {
        Productos p = new Productos();
        Usuario u = new Usuario();
        public ApplicationDbContext db { get; set; }


        public Producto(ApplicationDbContext tablas) {
            db = tablas;
        }
        [HttpGet]
        public IActionResult Index(int Pag, int Registros, string Search)
        {
            List<Productos> ListaProductos = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                ListaProductos = db.productos.Include(e=>e.categorias).Where(i=>i.nombre.Contains(Search)).ToList();
            }
            else
            {
                ListaProductos = db.productos.Include(e => e.categorias).ToList();
            }
            object[] respuesta = new Paginador<Productos>().paginador(ListaProductos, Pag, Registros, "Producto", "Producto", "Index", host);

            DataPaginador<Productos> Modelo = new DataPaginador<Productos>
            { Lista = (List<Productos>)respuesta[2], 
               Pagi_info = (string)respuesta[0],
                Pagi_navegacion = (string)respuesta[1], 
                Search = Search, 
                Registros = Registros, 
                Modelo = new Productos() 
            };
            return View(Modelo);
        }

        public IActionResult Agregar()
        {
            p.categoria = db.categorias.ToList();
            return View(p);
        }

        public IActionResult Chat() {
            return View();
        }

        public IActionResult Editar(int id) {
            Productos r = db.productos.Find(id);
            if (r== null) {
                return RedirectToAction("index");
            }
            r.categoria = db.categorias.ToList();
            return View(r);
        }

        public IActionResult Inactivar() {
            return RedirectToAction("Index");        
        }

        public IActionResult Guardar(Productos formulario) {
            if (!ModelState.IsValid) {
                p.categoria = db.categorias.ToList();
                return RedirectToAction("Agregar", p);
            }
            try {
                if(formulario.Imagen2.Length > 0)
                {
                    var direccion = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes", formulario.Imagen2.FileName);
                    using (var v = System.IO.File.Create(direccion))
                    {
                        formulario.Imagen2.CopyTo(v);
                        formulario.Imagen = formulario.Imagen2.FileName;
                    }
                    db.Add(formulario);
                    db.SaveChanges();
                }
            } catch(Exception a) { }
            return RedirectToAction("Index");
        }

        public IActionResult Modificar(Productos form) {
            if (!ModelState.IsValid) {
                return RedirectToAction("Editar", form);
            }
            
            if (form.id_productos == 0)
            {
                return RedirectToAction("Editar", form);
            }
            else
            {
                try
                {
                    if (form.Imagen2.Length > 0)
                    {
                        var direccion = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes", form.Imagen2.FileName);
                        using (var v = System.IO.File.Create(direccion))
                        {
                            form.Imagen2.CopyTo(v);
                            form.Imagen = form.Imagen2.FileName;
                        }
                        db.Update(form);
                        db.SaveChanges();

                    }
                }
                catch (Exception p) { 
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Estado(int id) {
            Productos bu = db.productos.Find(id);
            if (bu == null) {
                return RedirectToAction("index");
            }
            if (bu.estado == 1)
            {
                bu.estado = 0;
                db.Update(bu);
                db.SaveChanges();
            }
            else {
                bu.estado = 1;
                db.Update(bu);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult AgregarU() {
            u.usuarios = db.usuarios.ToList();
            return View(u);        
        }
        [HttpGet]
        public IActionResult IndexU(int Pag, int Registros, string Search) {
            List<Usuario> ListaUsuarios = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                ListaUsuarios = db.usuarios.Where(i => i.correo.Contains(Search)).ToList();
            }
            else
            {
                ListaUsuarios = db.usuarios.ToList();
            }
            object[] respuesta = new Paginador<Usuario>().paginador(ListaUsuarios, Pag, Registros, "Producto", "Producto", "Index", host);

            DataPaginador<Usuario> Modelo = new DataPaginador<Usuario>
            {
                Lista = (List<Usuario>)respuesta[2],
                Pagi_info = (string)respuesta[0],
                Pagi_navegacion = (string)respuesta[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Usuario()
            };
            return View(Modelo);
        }
        public IActionResult GuardarU(Usuario y) {
            if (!ModelState.IsValid) {
                return RedirectToAction("IndexU",y);
            }
            try {
                db.Add(y);
                db.SaveChanges();
            } catch (Exception e) { 
            }
            return RedirectToAction("IndexU");
        }

        public IActionResult EditarU(int id) {
            Usuario ub = db.usuarios.Find(id);
            if (ub == null) {
                return RedirectToAction("IndexU", ub);
            }
            return View(ub);
        }

        public IActionResult EstadoU(int id) {
            Usuario bu = db.usuarios.Find(id);
            if (bu == null)
            {
                return RedirectToAction("IndexU");
            }
            if (bu.estado == 1)
            {
                bu.estado = 0;
                db.Update(bu);
                db.SaveChanges();
            }
            else
            {
                bu.estado = 1;
                db.Update(bu);
                db.SaveChanges();
            }
            return RedirectToAction("IndexU");
        }

        public IActionResult ModificarU(Usuario p) {
            if (!ModelState.IsValid) {
                return RedirectToAction("IndexU",p);
            }
            if (p.id_usuario == 0)
            {
                return RedirectToAction("IndexU", p);
            }
            else {
                try {
                    db.Update(p);
                    db.SaveChanges();
                } catch (Exception a) { 

                }            
            }
            return RedirectToAction("IndexU");
        }
    } 
}
