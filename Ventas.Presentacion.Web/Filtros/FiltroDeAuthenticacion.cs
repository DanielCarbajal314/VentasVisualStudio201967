using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Ventas.Infraestructura.Seguridad;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Filtros
{
    public class FiltroDeAuthenticacion : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            GestorDeJWT jwt = new GestorDeJWT();

            string token = actionContext.Request.Headers.Authorization.ToString();
            if (token == null)
            {
                throw new Exception("No se encontro la cabezera de session en la peticion");
            }
            Session session = jwt.SacarSessionDesdeElToken(token);
            HttpContext.Current.Items["Session"] = session;
        }
    }
}