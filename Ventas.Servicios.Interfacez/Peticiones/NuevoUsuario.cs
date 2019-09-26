using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Peticiones
{
    public class NuevoUsuario
    {
        public string NombreCompleto { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public string ConfirmacionDePassword { get; set; }
        public string Correo { get; set; }
        public IEnumerable<string> NombresDeLosRoles { get; set; }
    }
}
