using System.Collections.Generic;
using System.Web.Http;
using Ventas.Presentacion.Web.Controllers.API.Compartido;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API
{
    public class ClientesController : ApiControllerAuthenticado
    {
        IGestorDeClientes _gestorDeClientes;

        public ClientesController(IGestorDeClientes gestorDeClientes)
        {
            this._gestorDeClientes = gestorDeClientes;
        }


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
            var session = this.Session;
            return this._gestorDeClientes.ListarTodosLosClientes();
        }

        [HttpPost]
        public ClienteCompleto Registrar(NuevoCliente nuevoCliente)
        {
            return this._gestorDeClientes.RegistrarNuevoCliente(nuevoCliente);
        }
    }
}
