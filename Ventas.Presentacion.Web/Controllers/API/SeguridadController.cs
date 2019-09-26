using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ventas.Infraestructura.Seguridad;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API
{
    public class SeguridadController : ApiController
    {
        private IGestorDeSession _gestorDeSessiones = new GestorDeSession();
        private GestorDeJWT _gestorDeJWT = new GestorDeJWT();

        [HttpPost]
        public string Login(IntentoDeInicioDeSession peticion)
        {
            var session = _gestorDeSessiones.Login(peticion);
            return this._gestorDeJWT.CrearToken(session);
        }

        [HttpPost]
        public void Registrar(NuevoUsuario peticion)
        {
            _gestorDeSessiones.Registrar(peticion);
        }
    }
}
