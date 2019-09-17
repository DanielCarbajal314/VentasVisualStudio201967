using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructura.ContextoDeDatos;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Servicios.MapaDeConversiones;

namespace Ventas.Servicios.ImplementacionConSQL
{
    public class GestorDeClientes : IGestorDeClientes
    {
        public ClienteCompleto ActualizarCliente(ActualizacionDeCliente actualizacionDeCliente)
        {
            using (var db = new VentasDB())
            {
                var cliente = db.Clientes.Find(actualizacionDeCliente.Id);
                actualizacionDeCliente.ActualizarRegistro(cliente);
                db.SaveChanges();
                return cliente.ConvertirADTOCompleto();
            }
        }

        public ClienteCompleto BuscarPorId(int Id)
        {
            using (var db = new VentasDB())
            {
                return db.Clientes.Find(Id).ConvertirADTOCompleto();
            }
        }

        public IEnumerable<ClienteRegistrado> ListarTodosLosClientes()
        {
            using (var db = new VentasDB())
            {
                return db.Clientes.ToList().Select(x=>x.ConvertirADTO());
            }
        }

        public ClienteCompleto RegistrarNuevoCliente(NuevoCliente nuevoCliente)
        {
            using (var db = new VentasDB())
            {
                var cliente = nuevoCliente.ConvertirAEntidad();
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return cliente.ConvertirADTOCompleto();
            }
        }
    }
}
