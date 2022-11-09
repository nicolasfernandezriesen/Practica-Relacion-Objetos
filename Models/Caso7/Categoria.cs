using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso7
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
        public Categoria() { }
        public Categoria(string nombre)
        {
            Nombre = nombre;
        }
        public Categoria(string nombre, List<Producto> productos)
        {
            Nombre= nombre;
            Productos= productos;
        }

    }
}
