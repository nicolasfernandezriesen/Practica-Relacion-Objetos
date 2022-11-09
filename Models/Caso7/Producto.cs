using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public List<DetalleFactura> Facturas { get; set; }
        public Categoria Categoria { get; set; }
        public Producto() { }
        public Producto(string nombre, double precio)
        {
            Nombre= nombre;
            Precio= precio;
        }
        public Producto(string nombre, double precio, List<DetalleFactura> facturas, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Facturas = facturas;
            Categoria = categoria;
        }
    }
}
