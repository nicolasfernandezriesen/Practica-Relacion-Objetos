using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso4
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public Docente Docente { get; set; }
        public Alumno() { }
        public Alumno(string nombre, string apellido, int legajo, Docente docente)
        {
            Nombre= nombre;
            Apellido= apellido;
            Legajo= legajo;
            Docente= docente;
        }
    }
}
