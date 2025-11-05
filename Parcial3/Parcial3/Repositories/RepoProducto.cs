using Parcial3.Data;
using Parcial3.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Repositories
{
    public class RepoProducto
    {

        public static void AgregarProducto(Producto producto)
        {

            using (var context = new ApplicationDbContext())
            {

                context.productos.Add(producto);
                context.SaveChanges();


            }

        }

    }
}
