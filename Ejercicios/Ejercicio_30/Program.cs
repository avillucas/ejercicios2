using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia grandPrix = new Competencia(10, 2);
            AutoF1 auto1 = new AutoF1(1, "fiordos");
            AutoF1 auto2 = new AutoF1(3, "chevrolet");
            AutoF1 auto3 = new AutoF1(2, "ford");            
            AutoF1 auto4 = new AutoF1(3, "chevrolet");
            if (grandPrix + auto1)
            {
                Console.WriteLine("El auto1 se agrego a la competencia");
            }
            if (grandPrix + auto2)
            {
                Console.WriteLine("El auto2 se agrego a la competencia");
            }
            if (grandPrix + auto3)
            {
                Console.WriteLine("El auto3 se agrego a la competencia");
            }
            else
            {
                Console.WriteLine("El auto3 NO se agrego a la competencia");
            }
            if (grandPrix + auto4)
            {
                Console.WriteLine("El auto4 se agrego a la competencia");
            }
            else
            {
                Console.WriteLine("El auto4 NO se agrego a la competencia");
            }
            //
            Console.WriteLine("Auto 1 {0}", auto1.MostrarDatos());
            Console.WriteLine("Auto 2 {0}", auto2.MostrarDatos());
            Console.WriteLine("Auto 3 {0}", auto3.MostrarDatos());
            Console.WriteLine("Auto 4 {0}", auto4.MostrarDatos());
            Console.ReadKey();
        }
    }
}
