using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API
{
    public class ProductosController : ApiController
    {
        IGestorDeProductos _gestorDeProductos = new GestorDeProductos();

        [HttpGet]
        public IEnumerable<ProductoRegistrado> porCategoria(int id)
        {
            return this._gestorDeProductos.ListarProductosPorCategoria(id);
        }

        [HttpGet]
        public IEnumerable<CategoriaRegistrada> categorias()
        {
            return this._gestorDeProductos.ListarTodasLasCategorias();
        }
    }
}
