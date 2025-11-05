using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3.Modelo
{
    public class Cliente
    {

        public int id {  get; set; }

        public string DNI { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public Cliente(string Dni,string Nombre,string Apellido)
        {
            this.DNI = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;

        }
        public Cliente() { }
    }
}
