using Parcial3.Data;
using Parcial3.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Repositories
{
    public class RepoVenta
    {
        public static void AgregarVenta(Venta venta)
        {

            using (var context = new ApplicationDbContext())
            {

                context.ventas.Add(venta);
                context.SaveChanges();


            }

        }
    }
}
