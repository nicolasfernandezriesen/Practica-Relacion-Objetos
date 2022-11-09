using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public Persona() { }
        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
