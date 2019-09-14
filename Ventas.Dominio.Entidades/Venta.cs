using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;
using Ventas.Dominio.Entidades.Compartido.Enums;

namespace Ventas.Dominio.Entidades
{
    public class Venta: EntidadBase
    {
        public TipoDeVenta TipoDeVenta { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public HashSet<DetalleVenta> Detalles { get; set; }
    }
}
