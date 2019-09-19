using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructura.ContextoDeDatos;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Servicios.MapaDeConversiones;

namespace Ventas.Servicios.ImplementacionConSQL
{
    public class GestorDePersonas : IGestorDePersonas
    {
        public IEnumerable<PersonaGenerica> ListarClientes()
        {
            using (var db = new VentasDB())
            {
                return db.Clientes.ToList().Select(x => x.ConvertirADTOSimplificado());
            }
        }

        public IEnumerable<PersonaGenerica> ListarVendedores()
        {
            using (var db = new VentasDB())
            {
                return db.Vendedores.ToList().Select(x => x.ConvertirADTOSimplificado());
            }
        }
    }
}
