using Microsoft.AspNetCore.Http;
using ProyectoCristian.Areas.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Producto.Models
{
    public class Productos
    {
        [Key]
        public int id_productos { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        [StringLength(maximumLength: 50, ErrorMessage = ("Maximo 50 caracteres"))]
        public string nombre { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        
        public string descripcion { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public int id_categoria { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public int precio { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public int cantidad { get; set; }
        public int estado { get; set; }
        public  Categorias categorias { get; set; }
        public string Imagen { get; set; }
        [NotMapped]
        public IFormFile Imagen2 { get; set; }
        [NotMapped]
        public List<Productos> producto { get; set; }

        [NotMapped]
        public List<Categorias> categoria { get; set; }

        public ICollection<DetalleCompra> productoCompra { get; set; }

    }
}
