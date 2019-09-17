using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Respuestas
{
    public class ClienteRegistrado
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Celular { get; set; }
    }
}
