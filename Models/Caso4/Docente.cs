using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso4
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public List<Alumno> Alumnos { get; set;}
        public Docente() { }
        public Docente(string nombre, string apellido, int matricula, List<Alumno> alumnos)
        {
            Nombre= nombre;
            Apellido= apellido;
            Matricula= matricula;
            Alumnos= alumnos;
        }
    }
}
