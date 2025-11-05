using Parcial3.Data;
using Parcial3.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Repositories
{
    public class RepoCliente
    {

        public static void AgregarCliente(Cliente cliente)
        {

            using (var context = new ApplicationDbContext())
            {

                context.clientes.Add(cliente);
                context.SaveChanges();


            }

        }
        


    }
}
