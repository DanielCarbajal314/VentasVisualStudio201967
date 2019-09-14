using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;

namespace Ventas.Dominio.Entidades
{
    public class Vendedor: PersonaContacto
    {
        public double PorcentajeDeComision { get; set; }
        public HashSet<Venta> Ventas { get; set; }
    }
}
