using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Ventas.Presentacion.Web.Filtros;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Presentacion.Web.Controllers.API.Compartido
{
    [FiltroDeAuthenticacion]
    public class ApiControllerAuthenticado : ApiController
    {
        public Session Session { get {
                return (Session)HttpContext.Current.Items["Session"];
            }
        }
    }
}