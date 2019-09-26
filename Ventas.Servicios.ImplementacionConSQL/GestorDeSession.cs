using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Infraestructura.ContextoDeDatos;
using Ventas.Infraestructura.Seguridad;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Servicios.MapaDeConversiones;

namespace Ventas.Servicios.ImplementacionConSQL
{
    public class GestorDeSession : IGestorDeSession
    {
        private GestorDeCriptografia _gestorDeCriptografia;

        public GestorDeSession()
        {
            this._gestorDeCriptografia = new GestorDeCriptografia();
        }

        public Session Login(IntentoDeInicioDeSession peticion)
        {
            using (var db = new VentasDB())
            {
                var usuario = db.Usuarios
                                .Include("Roles")
                                .FirstOrDefault(x=>x.Alias.Equals(peticion.Alias));
                if(usuario == null) throw new InvalidOperationException("El usuario no existe o el password es equivocado");
                if (elPasswordEsValido(usuario, peticion.Password))
                {
                    return usuario.ConvertirADTO();
                }
                else
                {
                    throw new InvalidOperationException("El usuario no existe o el password es equivocado");
                }
            }
        }

        public void Registrar(NuevoUsuario peticion)
        {
            using (var db = new VentasDB())
            {
                var usuario = db.Usuarios
                                .FirstOrDefault(x => x.Alias.Equals(peticion.Alias));
                if (usuario != null) throw new InvalidOperationException("Ya existe un usuario con ese nombre");
                if (!peticion.Password.Equals(peticion.ConfirmacionDePassword)) throw new InvalidOperationException("El password y su confirmacion no coinciden");

                var nuevoUsuario = peticion.ConvertirAEntidad();
                nuevoUsuario.Password = this._gestorDeCriptografia.EncriptarEnAES256(peticion.Password);
                db.Roles
                    .Where(x => peticion.NombresDeLosRoles.Contains(x.Nombre))
                    .ToList()
                    .ForEach(x => nuevoUsuario.Roles.Add(x));
                db.Usuarios.Add(nuevoUsuario);
                db.SaveChanges();
            }
        }

        private bool elPasswordEsValido(Usuario usuario, string password)
        {
            var passwordEncriptado = this._gestorDeCriptografia.DesencriptarAES256(usuario.Password);
            return password.Equals(passwordEncriptado);
        }
    }
}
