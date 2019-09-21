using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Dominio.Entidades;
using Ventas.Dominio.Entidades.Compartido.Enums;

namespace Ventas.Servicios.MapaDeConversiones
{
    public static class MapaDeVenta
    {
        public static Venta ConvertirAEntidad(this NuevaVenta nuevaVenta)
        {
            HashSet<DetalleVenta> detalleVentas = new HashSet<DetalleVenta>(
                nuevaVenta.Detalles.Select(x => new DetalleVenta() {
                    Cantidad = x.Cantidad,
                    ProductoId = x.IdProducto,
                    SubTotal = x.Total
                }));

            return new Venta()
            {
                ClienteId = nuevaVenta.IdCliente,
                VendedorId = nuevaVenta.IdVendedor,
                Fecha = DateTime.Now,
                TipoDeVenta = (TipoDeVenta)nuevaVenta.TipoDeVenta,
                Total = nuevaVenta.Total,
                Detalles = detalleVentas
            };
        }
    }
}
