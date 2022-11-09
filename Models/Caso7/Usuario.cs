using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario() { }
        public Usuario(string nombre, string password)
        {
            Nombre= nombre;
            Password= password;
        }
        public Usuario(string nombre, string password, Cliente cliente)
        {
            Nombre= nombre;
            Password= password;
            Cliente= cliente;
        }

    }
}
