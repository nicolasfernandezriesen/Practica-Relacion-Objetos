using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso6
{
    public class Clinica
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Director Director { get; set; }
        public Clinica() { }
        public Clinica(string nombre, string direccion, string telefono, Director director)
        {
            Nombre= nombre;
            Direccion= direccion;
            Telefono= telefono;
            Director= director;
        }
    }
}
