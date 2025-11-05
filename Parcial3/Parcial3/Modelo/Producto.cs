using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Modelo
{
    public class Producto
    {
        public int Id { get; set; }

        public string NombreProducto { get; set; }

        public float Precio { get; set; }

        public int Stock { get; set; }

        public Producto(string NombreProducto, float Precio, int Stock)
        {
            this.NombreProducto = NombreProducto;
            this.Precio = Precio;
            this.Stock = Stock;


        }
        public Producto() { }


    }
}
