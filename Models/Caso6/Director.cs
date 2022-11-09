using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso6
{
    public class Director
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
        public Clinica Clinica { get; set; }
        public Director() { }
        public Director(string nombre, string apellido, string legajo, Clinica clinica)
        {
            Nombre= nombre;
            Apellido= apellido;
            Legajo= legajo;
            Clinica= clinica;
        }
    }
}
