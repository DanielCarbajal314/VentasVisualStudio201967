using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Servicios.Interfacez.Respuestas
{
    public class ClienteCompleto
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string UBIGEO { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
    }
}
