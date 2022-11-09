using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso2
{
    public class Pedido
    {
        public DateTime FechaEntrega { get; set; }
        public string Direccion { get; set; }
        public string Paquete { get; set; }
        public int CantPaquete { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido() { }
        public Pedido(DateTime fechaEntrega, string direccion, string paquete, int cantPaquete, Cliente cliente)
        {
            FechaEntrega = fechaEntrega;
            Direccion = direccion;
            Paquete = paquete;
            CantPaquete = cantPaquete;
            Cliente = cliente;
        }
    }
}
