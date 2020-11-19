using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCristian.Areas.Producto.Models
{
    public class Categorias
    {
        [Key]
        public int id_categoria { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public string nombre { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public int estado { get; set; }
        [Required(ErrorMessage = ("Este campo es requerido"))]
        public string descripcion { get; set;}
        
        public ICollection<Productos> productos { get; set; }

        

    }
}
