using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;

namespace Ventas.Dominio.Entidades
{
    public class Usuario: EntidadBase
    {
        public string NombreCompleto { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }
        public HashSet<Rol> Roles { get; set; }
    }
}
