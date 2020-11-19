using ProyectoCristian.Areas.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Producto.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        [Required(ErrorMessage =("Campo requerido"))]
        public string correo { get; set; }
        [Required(ErrorMessage =("Campo requerido"))]
        public string clave { get; set; }

        public int rol { get; set; }
        public int estado { get; set; }
        [NotMapped]
        public List<Usuario> usuarios { get; set; }
        public ICollection<Compras> Compra { get; set; }
    }
}
