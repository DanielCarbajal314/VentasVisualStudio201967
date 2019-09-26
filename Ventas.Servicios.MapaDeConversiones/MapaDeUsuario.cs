using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.MapaDeConversiones
{
    public static class MapaDeUsuario
    {
        public static Session ConvertirADTO(this Usuario usuario)
        {
            return new Session()
            {
                IdUsuario = usuario.Id,
                NombreDeUsuario = usuario.NombreCompleto,
                Roles = usuario.Roles.Select(x => x.Nombre)
            };
        }

        public static Usuario ConvertirAEntidad(this NuevoUsuario peticion)
        {
            return new Usuario()
            {
                Alias = peticion.Alias,
                Correo = peticion.Correo,
                NombreCompleto = peticion.NombreCompleto
            };
        }
    }
}
