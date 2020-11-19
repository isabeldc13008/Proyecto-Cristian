using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoCristian.Areas.Producto.Models;
using ProyectoCristian.Areas.Usuarios.Models;

namespace ProyectoCristian.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Productos> productos { get; set; }

        public DbSet<Categorias> categorias { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<DetalleCompra> detalleCompra { set; get; }
        public DbSet<Compras> compras { get; set; }
    }
}
