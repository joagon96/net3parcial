using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Entidades
{
    public class TipoPersona
    {
        public int Id;
        public string Descripcion;
        public TipoPersona()
        {

        }
        public TipoPersona(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}
