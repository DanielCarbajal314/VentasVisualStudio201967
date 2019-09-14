using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;

namespace Ventas.Dominio.Entidades
{
    public class Categoria : EntidadBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public HashSet<Producto> Productos { get; set; }
    }
}
