using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Peticiones;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Servicios.Interfacez
{
    public interface IGestorDeSession
    {
        Session Login(IntentoDeInicioDeSession peticion);
        void Registrar(NuevoUsuario peticion);
    }
}
