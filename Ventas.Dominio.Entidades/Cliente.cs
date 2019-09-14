using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;
using Ventas.Dominio.Entidades.Compartido.Enums;

namespace Ventas.Dominio.Entidades
{
    public class Cliente: PersonaContacto
    {
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public HashSet<Venta> Ventas { get; set; }
    }
}
