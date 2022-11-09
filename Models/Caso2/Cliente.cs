using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso2
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public Cliente() { }
        public Cliente(string nombre, string apellido, string dni, List<Pedido> pedidos)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Pedidos = pedidos;
        }
    }
}
