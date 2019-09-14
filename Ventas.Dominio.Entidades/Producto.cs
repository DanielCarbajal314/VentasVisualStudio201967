using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades.Compartido;

namespace Ventas.Dominio.Entidades
{
    public class Producto: EntidadBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public HashSet<DetalleVenta> Detalles { get; set; }
    }
}
