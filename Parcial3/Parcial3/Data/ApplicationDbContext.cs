using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3.Modelo;

namespace Parcial3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> clientes {  get; set; }

        public DbSet<Producto> productos { get; set; }
        
        public DbSet<Venta> ventas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=Parcial3;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }
    }
}
