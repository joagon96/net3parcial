using System;
using Basso.Datos;
using Basso.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Basso.Utiles
{
    public class Validaciones
    {
        public Validaciones()
        {

        }
        public static bool EsFechaDeNacimientoValida(DateTime fech)
        {
            
            DateTime fechHoy = DateTime.Now;
            if ((fechHoy.Year - fech.Year) > 110)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
