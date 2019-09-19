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
    public class PersonasController : ApiController
    {
        IGestorDePersonas _gestorDePersonas = new GestorDePersonas();

        [HttpGet]
        public IEnumerable<PersonaGenerica> Clientes()
        {
            return this._gestorDePersonas.ListarClientes();
        }

        [HttpGet]
        public IEnumerable<PersonaGenerica> Vendedores()
        {
            return this._gestorDePersonas.ListarVendedores();
        }
    }
}
