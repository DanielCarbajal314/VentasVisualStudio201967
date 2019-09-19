using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Dominio.Entidades;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.MapaDeConversiones
{
    public static class MapaDeProductos
    {
        public static ProductoRegistrado ConvertirADTO(this Producto producto)
        {
            return new ProductoRegistrado()
            {
                Descripcion = producto.Descripcion,
                Id = producto.Id,
                Nombre = producto.Nombre,
                PrecioUnitario = producto.Precio
            };
        }

        public static CategoriaRegistrada ConvertirADTO(this Categoria categoria)
        {
            return new CategoriaRegistrada()
            {
                Descripcion = categoria.Descripcion,
                Id = categoria.Id,
                Nombre = categoria.Nombre
            };
        }
    }
}
