using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;

namespace Ventas.Dominio.Entidades
{
    public class PersonaContacto: EntidadBase
    {
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string UBIGEO { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
    }
}
