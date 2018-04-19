using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    /// <summary>
    /// El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango
    /// correcto, sino retornará un string vacio “”. En el set, la asignará si esta ya existe. Si el índice es superior al
    /// máximo existente, agregará una nueva página.
    /// Generar el código en el Main para probar la clase.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Libro viajeAlCentroDeLaTierra = new Libro();
            viajeAlCentroDeLaTierra[0] = "El encuentro pagina 1";
            viajeAlCentroDeLaTierra[1] = "El encuentro pagina 2";
            //Si el índice es superior al máximo existente, agregará una nueva página.
            viajeAlCentroDeLaTierra[3] = "El encuentro pagina 3";

            //El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango
            Console.WriteLine(" pagina 1 {0}",viajeAlCentroDeLaTierra[1]);
            Console.WriteLine(" pagina 2 {0}", viajeAlCentroDeLaTierra[2]);
            Console.WriteLine(" pagina 6 {0}", viajeAlCentroDeLaTierra[6]);
            Console.ReadKey();
        }
    }
}
