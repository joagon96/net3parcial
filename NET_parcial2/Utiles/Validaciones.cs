using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utiles
{
    public class Validaciones
    {
        public static bool EsMailValido(string emailIngresado)
        {
            string expRegular = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if(Regex.IsMatch(emailIngresado, expRegular))
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
