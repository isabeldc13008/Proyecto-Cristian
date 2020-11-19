using ProyectoCristian.Areas.Producto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Usuarios.Models
{
    public class DetalleCompra
    {
        [Key]
        public int id_detallecompra { get; set; }
        public int id_producto { get; set; }

        public int id_compra { get; set; }

        public Productos producto { get; set; }
        public Compras compra { get; set; }

        
    }
}
