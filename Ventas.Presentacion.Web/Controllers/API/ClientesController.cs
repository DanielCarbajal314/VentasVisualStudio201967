using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API
{
    public class ClientesController : ApiController
    {
        IGestorDeClientes _gestorDeClientes = new GestorDeClientes();

        [HttpPut]
        public ClienteCompleto Actualizar(ActualizacionDeCliente actualizacionDeCliente)
        {
            return this._gestorDeClientes.ActualizarCliente(actualizacionDeCliente);
        }

        [HttpGet]
        public ClienteCompleto Buscar(int Id)
        {
            return this._gestorDeClientes.BuscarPorId(Id);
        }

        [HttpGet]
        public IEnumerable<ClienteRegistrado> ListarTodos()
        {
            return this._gestorDeClientes.ListarTodosLosClientes();
        }

        [HttpPost]
        public ClienteCompleto Registrar(NuevoCliente nuevoCliente)
        {
            return this._gestorDeClientes.RegistrarNuevoCliente(nuevoCliente);
        }
    }
}
