using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso5
{
    public class Empleado
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }
        public Empleado() { }
        public Empleado(string legajo, string nombre, string apellido, DatosContacto datosContacto)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            DatosContacto = datosContacto;
        }
    }
}
