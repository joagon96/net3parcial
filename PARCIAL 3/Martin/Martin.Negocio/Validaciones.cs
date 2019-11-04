using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Negocio
{
    public static class Validaciones
    {
        public static bool EsFechaNacimientoValida(DateTime fecha)
        {
            if (fecha < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
