using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.Interfacez
{
    public interface IGestorDeProductos
    {
        IEnumerable<CategoriaRegistrada> ListarTodasLasCategorias();
        IEnumerable<ProductoRegistrado> ListarProductosPorCategoria(int categoriaId);
    }
}
