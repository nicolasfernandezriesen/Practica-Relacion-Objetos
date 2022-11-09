using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Empleado : Persona
    {
        public string Legajo { get; set; }
        public List<Factura> Factura { get; set; }
        public Empleado() { }
        public Empleado(string legajo, string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
            Legajo= legajo;
        }
        public Empleado(string legajo, List<Factura> facturas, string nombre, string apellido, string dni) : base (nombre, apellido, dni)
        {
            Legajo = legajo;
            Factura = facturas;
        }
    }
}
