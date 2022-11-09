using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso5
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public DatosContacto() { }
        public DatosContacto(string domicilio, long telefono, string email, Empleado empleado, Cliente cliente)
        {
            Domicilio= domicilio;
            Telefono= telefono;
            Email= email;
            Empleado= empleado;
            Cliente= cliente;
        }
    }
}
