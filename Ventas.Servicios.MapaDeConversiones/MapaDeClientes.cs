using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Dominio.Entidades.Compartido.Enums;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.MapaDeConversiones
{
    public static class MapaDeClientes
    {
        public static ClienteCompleto ConvertirADTOCompleto(this Cliente cliente)
        {
            return new ClienteCompleto()
            {
                Id = cliente.Id,
                Celular = cliente.Celular,
                Correo = cliente.Correo,
                Direccion = cliente.Direccion,
                DNI = cliente.DNI,
                FechaNacimiento = cliente.FechaNacimiento,
                NombreCompleto = cliente.NombreCompleto,
                Sexo = cliente.Sexo.ToString(),
                UBIGEO = cliente.UBIGEO
            };
        }

        public static ClienteRegistrado ConvertirADTO(this Cliente cliente)
        {
            return new ClienteRegistrado()
            {
                Id = cliente.Id,
                Celular = cliente.Celular,
                DNI = cliente.DNI,
                NombreCompleto = cliente.NombreCompleto,
            };
        }

        public static Cliente ConvertirAEntidad(this NuevoCliente nuevoCliente)
        {
            return new Cliente()
            {
                Celular = nuevoCliente.Celular,
                Correo = nuevoCliente.Correo,
                Direccion = nuevoCliente.Direccion,
                DNI = nuevoCliente.DNI,
                FechaNacimiento = nuevoCliente.FechaNacimiento,
                NombreCompleto = nuevoCliente.NombreCompleto,
                Sexo = nuevoCliente.Sexo.Equals("Masculino")?Sexo.Masculino:Sexo.Femenino,
                UBIGEO = nuevoCliente.UBIGEO
            };
        }

        public static void ActualizarRegistro(this ActualizacionDeCliente actualizacionDeCliente, Cliente cliente)
        {
            cliente.UBIGEO = actualizacionDeCliente.UBIGEO;
            cliente.Direccion = actualizacionDeCliente.Direccion;
            cliente.Correo = actualizacionDeCliente.Correo;
            cliente.Celular = actualizacionDeCliente.Celular;
        }
    }
}
