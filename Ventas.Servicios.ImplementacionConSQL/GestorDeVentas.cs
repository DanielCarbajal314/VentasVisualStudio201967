using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Infraestructura.ContextoDeDatos;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Servicios.MapaDeConversiones;

namespace Ventas.Servicios.ImplementacionConSQL
{
    public class GestorDeVentas : IGestorDeVentas
    {
        public IEnumerable<VentaRegistrada> ListarTodasLasVentas()
        {
            using (var db = new VentasDB())
            {
                return db.Ventas.Select(x => new
                {
                    Id = x.Id,
                    Fecha = x.Fecha,
                    NombreVendedor = x.Vendedor.NombreCompleto,
                    NombreCliente = x.Cliente.NombreCompleto,
                    Total = x.Total
                })
                .ToList()
                .Select(x => new VentaRegistrada()
                {
                    Fecha = x.Fecha,
                    Id = x.Id,
                    MontoTotal = x.Total,
                    NombreCliente = x.NombreCliente,
                    NombreDelVendedor = x.NombreVendedor
                });
            }
        }

        public IEnumerable<MontoDeVentaPorVendedor> ListarVentasPorVendedor()
        {
            using (var db = new VentasDB())
            {
                return db.Ventas
                            .GroupBy(x => x.Vendedor.NombreCompleto, y=>y.Total)
                            .Select(x => new
                            {
                                vendedor = x.Key,
                                monto = x.Sum()
                            })
                            .ToList()
                            .Select(x=>new MontoDeVentaPorVendedor() {
                                MontoVendido = x.monto,
                                NombreVendedor = x.vendedor
                            });
            }
        }

        public VentaRegistrada RegistrarNuevaVenta(NuevaVenta nuevaVenta)
        {
            using (var db = new VentasDB())
            {
                Venta venta = nuevaVenta.ConvertirAEntidad();
                db.Ventas.Add(venta);
                db.SaveChanges();

                var informacionDeLaVenta = db.Ventas
                    .Where(x => x.Id.Equals(venta.Id))
                    .Select(x => new
                    {
                        NombreDelCliente = x.Cliente.NombreCompleto,
                        NombreDelVendedor = x.Vendedor.NombreCompleto
                    })
                    .First();

                return new VentaRegistrada()
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    MontoTotal = venta.Total,
                    NombreCliente = informacionDeLaVenta.NombreDelCliente,
                    NombreDelVendedor = informacionDeLaVenta.NombreDelVendedor
                };

            }
        }


    }
}
