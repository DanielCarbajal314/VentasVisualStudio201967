using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Venta.Infraestructura.Archivos
{
    public class Reporteador
    {
        public byte[] GenerarReporteDeVentas(IEnumerable<VentaRegistrada> ventas)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (var libro = new XLWorkbook())
            {
                var hoja = libro.Worksheets.Add("Ventas");
                hoja.Cell(1, 1).Value = "Id";
                hoja.Cell(1, 2).Value = "Cliente";
                hoja.Cell(1, 3).Value = "Vendedor";
                hoja.Cell(1, 4).Value = "Fecha";
                hoja.Cell(1, 5).Value = "Total";
                hoja.Range(1, 1, 1, 5).Style.Font.Bold = true;
                int fila = 2;
                ventas.ToList().ForEach(venta =>
                {
                    hoja.Cell(fila, 1).Value = venta.Id;
                    hoja.Cell(fila, 2).Value = venta.NombreCliente;
                    hoja.Cell(fila, 3).Value = venta.NombreDelVendedor;
                    hoja.Cell(fila, 4).Value = venta.Fecha;
                    hoja.Cell(fila, 5).Value = venta.MontoTotal;
                    fila++;
                });
                libro.SaveAs(memoryStream);
            }
            return memoryStream.ToArray();
        }
    }
}
