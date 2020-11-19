using ProyectoCristian.Areas.Producto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Usuarios.Models
{
    public class Compras
    {
        [Key]
        public int Id_compra { get; set; }

        public DateTime fecha { get; set; } = DateTime.Now;

        public int Id_usuario { get; set; }

        public int cantidad { get; set; }

        public int valor { get; set; }
        
        public Usuario usuario { get; set; }
        public ICollection<DetalleCompra> compra { get; set;
        }

    }
}
