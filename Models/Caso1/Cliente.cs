using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso1
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario Usuario { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string apellido, Usuario usuario)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.Usuario = usuario;
        }
    }
}
