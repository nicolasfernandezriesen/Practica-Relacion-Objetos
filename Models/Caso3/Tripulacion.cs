using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Caso3
{
    public class Tripulacion
    {
        public string NombreEmpresa { get; set; }
        public List<Azafata> Azafatas { get; set; }
        public Tripulacion() { }
        public Tripulacion(string nombreEmpresa, List<Azafata> azafatas) 
        {
            NombreEmpresa = nombreEmpresa;
            Azafatas = azafatas;
        }
    }
}
