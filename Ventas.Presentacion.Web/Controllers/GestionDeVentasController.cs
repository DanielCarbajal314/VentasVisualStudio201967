using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venta.Infraestructura.Archivos;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;

namespace Ventas.Presentacion.Web.Controllers
{
    public class GestionDeVentasController : Controller
    {
        IGestorDeVentas _gestorDeVentas = new GestorDeVentas();
        Reporteador _reporteador = new Reporteador();
        // GET: GestionDeVentas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult reporteDeVentasEnExcel()
        {
            var ventas = this._gestorDeVentas.ListarTodasLasVentas();
            var excelEnBytes = this._reporteador.GenerarReporteDeVentas(ventas);
            return File(excelEnBytes, "application/vnd.ms-excel","Reporte.xlsx");
        }
    }
}