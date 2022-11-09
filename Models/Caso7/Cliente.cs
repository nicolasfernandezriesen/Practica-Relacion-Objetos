using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Cliente : Persona
    {
        public Usuario Usuario { get; set; }
        public List<Factura> Facturas { get; set; }
        public Cliente() { }
        public Cliente(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {

        }
        public Cliente(Usuario usuario, List<Factura> facturas,string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        { 
            Usuario= usuario;
            Facturas=facturas;
        }

    }
}
