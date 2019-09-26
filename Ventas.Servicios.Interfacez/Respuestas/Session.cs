using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Respuestas
{
    public class Session
    {
        public int IdUsuario { get; set; }
        public string NombreDeUsuario { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
