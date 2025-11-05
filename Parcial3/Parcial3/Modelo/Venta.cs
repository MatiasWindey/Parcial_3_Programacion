using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Modelo
{
    public class Venta
    {
        public int Id { get; set; }

        public string FechaVenta { get; set; }

        public string DniCliente { get; set; }

        public string ProductoComprado { get; set; }

        public int CantidadComprada { get; set; }

        public Venta(string FechaVenta,string DniCliente, string ProductoComprado, int CantidadComprada)
        {

            this.FechaVenta = FechaVenta;
            this.DniCliente = DniCliente;
            this.ProductoComprado = ProductoComprado;
            this.CantidadComprada = CantidadComprada;
                

        }
        public Venta() { }


    }
}
