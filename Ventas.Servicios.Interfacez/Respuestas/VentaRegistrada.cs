using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Respuestas
{
    public class VentaRegistrada
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreDelVendedor { get; set; }
        public double MontoTotal { get; set; }
        public DateTime Fecha { get; set; }
    }
}
