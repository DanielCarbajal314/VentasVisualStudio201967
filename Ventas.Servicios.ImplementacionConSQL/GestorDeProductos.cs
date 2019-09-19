using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructura.ContextoDeDatos;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Respuestas;
using Ventas.Servicios.MapaDeConversiones;

namespace Ventas.Servicios.ImplementacionConSQL
{
    public class GestorDeProductos : IGestorDeProductos
    {
        public IEnumerable<ProductoRegistrado> ListarProductosPorCategoria(int categoriaId)
        {
            using (var db = new VentasDB())
            {
                return db.Productos
                         .Where(x=>x.CategoriaId.Equals(categoriaId))
                         .ToList()
                         .Select(x => x.ConvertirADTO())
;           }
        }

        public IEnumerable<CategoriaRegistrada> ListarTodasLasCategorias()
        {
            using (var db = new VentasDB())
            {
                return db.Categorias.ToList().Select(x => x.ConvertirADTO());
            }
        }
    }
}
