using ProyectoCristian.Areas.Producto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Usuarios.Models
{
    public class CompraUsuario
    {
        public int total { get; set; }
        public int cantidad { get; set; }
        public List<Productos> productosc { get; set; }
    }
}
