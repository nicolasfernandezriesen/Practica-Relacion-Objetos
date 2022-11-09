using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Factura
    {
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Factura() { }
        public Factura(string tipo)
        {
            Tipo= tipo;
        }
        public Factura(string tipo, Cliente cliente, Empleado empleado, List<DetalleFactura> detalleFacturas)
        {
            Tipo = tipo;
            Cliente = cliente;
            Empleado = empleado;
            DetalleFacturas= detalleFacturas;
        }

    }
}
