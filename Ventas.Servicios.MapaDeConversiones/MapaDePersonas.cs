using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.MapaDeConversiones
{
    public static class MapaDePersonas
    {
        public static PersonaGenerica ConvertirADTOSimplificado(this Cliente cliente)
        {
            return new PersonaGenerica()
            {
                Id = cliente.Id,
                NombreCompleto = cliente.NombreCompleto
            };
        }

        public static PersonaGenerica ConvertirADTOSimplificado(this Vendedor vendedor)
        {
            return new PersonaGenerica()
            {
                Id = vendedor.Id,
                NombreCompleto = vendedor.NombreCompleto
            };
        }
    }
}
