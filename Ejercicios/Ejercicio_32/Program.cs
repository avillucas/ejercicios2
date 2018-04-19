using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generar los métodos en el Main para probar el código.
            Equipo estudiantes = new Equipo(3, "Estudiantes");
            Jugador elTopo = new Jugador(132, "El Topo Gimenez", 2, 1);
            Jugador teletubbieDomingues = new Jugador(111, "Teletubbie Dominguez", 2, 3);
            Jugador pipo = new Jugador(110, "El pipo", 2, 10);
            Jugador edgardoTom = new Jugador(1145666, "Edgardo Tom", 20, 1);
            Jugador elPipi = new Jugador(1231321, "Pipi gonzales");
            //
            if (estudiantes + teletubbieDomingues)
            {
                Console.WriteLine("Se agrego a teletubbie");
            }
            if (!(estudiantes + teletubbieDomingues))
            {
                Console.WriteLine("No se volvio a agregar a teletubbie");
            }
            if (estudiantes + pipo)
            {
                Console.WriteLine("Se agrego a pipo");
            }
            if (estudiantes + edgardoTom)
            {
                Console.WriteLine("Se agrego a edgardoTom");
            }
            if (estudiantes + elPipi)
            {
                Console.WriteLine("Se agrego a elPipi");
            }
            else
            {
                Console.WriteLine("elPipi quedo afuera");
            }
            Console.WriteLine("{0}", teletubbieDomingues.MostrarDatos());
            Console.ReadKey();
        }
    }
}
