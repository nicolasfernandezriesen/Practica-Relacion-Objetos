using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Cliente cliente { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string password, Cliente cliente)
        {
            Nombre = nombre;
            Password = password;
            this.cliente = cliente;
        }
    }
}
