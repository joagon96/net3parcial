using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Curso
    {
        // ¿public static era metodo de clase? Si. Osea se puede llamar asi: Negocio.RecuperarListaAlumnos (es uno solo para todas las instancias)
        public static List<Entidades.Alumno> RecuperarListaAlumnos() 
        {
            List<Entidades.Alumno> listaAlum = new List<Entidades.Alumno>();
            listaAlum.Add(new Entidades.Alumno(41168, "Burgardt", "Germán", 8.5));
            listaAlum.Add(new Entidades.Alumno(42154, "Marmol", "Pedro", 7.5));
            listaAlum.Add(new Entidades.Alumno(41168, "José", "Gimenes", 10.0));
            return listaAlum;
        }

    }
}



/*      ESTE CODIGO AGREGABA PERSONAS A LA LISTA MANUALMENTE
int op = 1;
// Mientras op=1 -> seguir agregando alumnos
while (op==1)
{
    Console.Write("Ingrese nombre alumno: ");
    nomAlum = Convert.ToString(Console.ReadLine());

    Console.Write("Ingrese apellido alumno: ");
    apeAlum = Convert.ToString(Console.ReadLine());

    Console.Write("Ingrese legajo alumno: ");
    legAlum = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese promedio alumno: ");
    promAlum = Convert.ToDouble(Console.ReadLine());

    alum = new Entidades.Alumno(legAlum, apeAlum, nomAlum, promAlum);
    listaAlum.Add(alum);

    Console.WriteLine();
    Console.Write("1: Agregar otro alumno; 0: Terminar");
    op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
*/