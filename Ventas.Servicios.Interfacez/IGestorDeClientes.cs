using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.Interfacez
{
    public interface IGestorDeClientes
    {
        ClienteCompleto BuscarPorId(int Id);
        IEnumerable<ClienteRegistrado> ListarTodosLosClientes();
        ClienteCompleto RegistrarNuevoCliente(NuevoCliente nuevoCliente);
        ClienteCompleto ActualizarCliente(ActualizacionDeCliente actualizacionDeCliente);
    }
}
