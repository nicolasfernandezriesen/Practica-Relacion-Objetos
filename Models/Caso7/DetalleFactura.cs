using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class DetalleFactura
    {
        public string DireccionEntrega { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public DetalleFactura() { }
        public DetalleFactura(string direccionEntrega)
        {
            DireccionEntrega= direccionEntrega;
        }
        public DetalleFactura(string direccionEntrega, Factura factura, Producto producto) 
        { 
            DireccionEntrega= direccionEntrega;
            Factura = factura;
            Producto = producto;
        }

    }
}
