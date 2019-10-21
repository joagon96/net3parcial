using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Martin.Utiles
{
    public class Validaciones
    {
        public static bool EsMailValido(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!Regex.IsMatch(email, expresion))
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
