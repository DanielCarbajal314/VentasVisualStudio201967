using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Ventas.Servicios.Interfacez.Validaciones;

namespace Ventas.Servicios.Interfacez.Peticiones
{
    public class NuevaVenta
    {
        [Range(1,int.MaxValue, ErrorMessage = "No es un Id de Vendedor valido")]
        public int IdVendedor { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "No es un Id de Cliente valido")]
        public int IdCliente { get; set; }
        [Range(1, Double.MaxValue, ErrorMessage = "No es un monto valido")]
        public double Total { get; set; }
        [StringRange(AllowableValues = new[] { "Boleta", "Factura" }, ErrorMessage = "La venta debe ser  con boleta o factura")]
        public string TipoDeVenta { get; set; }
        public IEnumerable<DetalleDeLaNuevaVenta> Detalles { get; set; }
    }
}
