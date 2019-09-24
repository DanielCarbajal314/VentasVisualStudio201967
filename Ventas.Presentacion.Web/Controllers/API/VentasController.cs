using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ventas.Presentacion.Web.Filtros;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API
{
    public class VentasController : ApiController
    {

        IGestorDeVentas _gestorDeVentas = new GestorDeVentas();

        [HttpGet]
        public IEnumerable<VentaRegistrada> ListarTodas()
        {
            return _gestorDeVentas.ListarTodasLasVentas();
        }

        [HttpGet]
        public IEnumerable<MontoDeVentaPorVendedor> VentasPorVendedor()
        {
            return _gestorDeVentas.ListarVentasPorVendedor();
        }

        [HttpPost]
        [FiltroDeValidacion]
        public VentaRegistrada Registrar(NuevaVenta nuevaVenta)
        {
            return _gestorDeVentas.RegistrarNuevaVenta(nuevaVenta);
        }
    }
}
