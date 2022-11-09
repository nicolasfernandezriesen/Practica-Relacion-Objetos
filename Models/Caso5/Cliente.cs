using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso5
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<DatosContacto> DatosContactos { get; set; }
        public Cliente() { }
        public Cliente(string nombre, string apellido, List<DatosContacto> datosContactos)
        {
            Nombre= nombre;
            Apellido= apellido;
            DatosContactos= datosContactos;
        }
    }
}
