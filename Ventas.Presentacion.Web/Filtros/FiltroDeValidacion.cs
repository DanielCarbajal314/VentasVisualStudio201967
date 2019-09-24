using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Ventas.Presentacion.Web.Filtros
{
    public class FiltroDeValidacion : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                var MensajesDeError = actionContext.ModelState.Values
                            .Select(x => x.Errors)
                            .Where(x => x.Count > 0)
                            .SelectMany(x => x)
                            .Select(x => x.ErrorMessage);
                actionContext.Response = actionContext.Request.CreateResponse(
                    HttpStatusCode.BadRequest,
                    new
                    {
                        MensajesDeError
                    }
                );
            }
        }
    }
}