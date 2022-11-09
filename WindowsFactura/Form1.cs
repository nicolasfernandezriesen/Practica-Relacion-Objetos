using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Caso7;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        Usuario usuario;
        Factura factura;
        List<Factura> facturas;
        Empleado empleado;
        DetalleFactura detalleFactura;
        List<DetalleFactura> detalleFacturas;
        List<Producto> productos;
        Producto producto1, producto2;
        Categoria categoria;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            categoria= new Categoria("Hardware");
            cliente= new Cliente("Sarah", "Juto", "25668951");
            empleado = new Empleado("L004FGT", "Jorge", "Joka", "31255986");
            usuario = new Usuario("Elrond","Queso"); ;
            facturas= new List<Factura>();
            factura= new Factura("A");
            detalleFacturas= new List<DetalleFactura>();
            detalleFactura= new DetalleFactura("Libertad 4232");
            producto1= new Producto("Mouse", 250.50);
            producto2 = new Producto("Monitor", 100000.00);
            productos = new List<Producto>();

            producto2.Categoria=categoria;
            producto1.Categoria = categoria;
            productos.Add(producto1);
            productos.Add(producto2);
            categoria.Productos=productos;

            cliente.Usuario=usuario;
            usuario.Cliente=cliente;

            factura.Cliente = cliente;
            factura.Empleado = empleado;
            facturas.Add(factura);
            empleado.Factura = facturas;

            detalleFactura.Producto = producto1;
            detalleFacturas.Add(detalleFactura);
            detalleFactura.Producto = producto2;
            detalleFacturas.Add(detalleFactura);

            MessageBox.Show("Objetos creados");

            gridProductos.DataSource = productos;
        }
    }
}
