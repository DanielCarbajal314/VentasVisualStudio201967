using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Peticiones
{
    public class NuevaVenta
    {
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public double Total { get; set; }
        public string TipoDeVenta { get; set; }
        public IEnumerable<DetalleDeLaNuevaVenta> Detalles { get; set; }
    }
}
