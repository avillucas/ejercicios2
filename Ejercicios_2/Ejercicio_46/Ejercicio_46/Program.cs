using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia grandPrix = new Competencia(10, 2, Competencia.TipoCompetencia.F1);
            Competencia motoPrix = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto1 = new AutoF1(1, "fiordos");
            MotoCross moto1 = new MotoCross(3, "honda");
            MotoCross moto2 = new MotoCross(1, "shamaha");
            AutoF1 auto2 = new AutoF1(3, "chevrolet");
            AutoF1 auto3 = new AutoF1(2, "ford");
            AutoF1 auto4 = new AutoF1(3, "chevrolet");

            try
            {
                if (motoPrix + moto1)
                {
                    Console.WriteLine("La moto2 se agrego a la competencia motoPrix");
                }
                else
                {
                    Console.WriteLine("La moto2 NO se agrego a la competencia motoPrix");
                }
                if (motoPrix + moto2)
                {
                    Console.WriteLine("La moto2 se agrego a la competencia motoPrix");
                }
                else
                {
                    Console.WriteLine("La moto2 NO se agrego a la competencia motoPrix");
                }


                if (grandPrix + auto1)
                {
                    Console.WriteLine("El auto1 se agrego a la competencia grandPrix");
                }
                else
                {
                    Console.WriteLine("El auto1 NO se agrego a la competencia grandPrix");
                }
                if (grandPrix + moto1)
                {
                    Console.WriteLine("El moto1 se agrego a la competencia grandPrix");
                }
                else
                {
                    Console.WriteLine("El moto1 NO se agrego a la competencia grandPrix");
                }
                if (grandPrix + auto2)
                {
                    Console.WriteLine("El auto2 se agrego a la competencia grandPrix");
                }
                else
                {
                    Console.WriteLine("El auto2 NO se agrego a la competencia grandPrix");
                }

                if (grandPrix + auto3)
                {
                    Console.WriteLine("El auto3 se agrego a la competencia grandPrix");
                }
                else
                {
                    Console.WriteLine("El auto3 NO se agrego a la competencia grandPrix");
                }
                if (grandPrix + auto4)
                {
                    Console.WriteLine("El auto4 se agrego a la competencia grandPrix");
                }
                else
                {
                    Console.WriteLine("El auto4 NO se agrego a la competencia grandPrix");
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
                Console.ForegroundColor = ConsoleColor.White;

            }
            //
            if (auto1.EnCompetencia)
                Console.WriteLine("Info {0}", auto1.MostrarDatos());
            if (auto2.EnCompetencia)
                Console.WriteLine("Info {0}", auto2.MostrarDatos());
            if (auto3.EnCompetencia)
                Console.WriteLine("Info {0}", auto3.MostrarDatos());
            if (auto4.EnCompetencia)
                Console.WriteLine("Info {0}", auto4.MostrarDatos());
            if (moto1.EnCompetencia)
                Console.WriteLine("Info 1 {0}", moto1.MostrarDatos());
            if (moto2.EnCompetencia)
                Console.WriteLine("Info 1 {0}", moto2.MostrarDatos());
            Console.ReadKey();
        }
    }
}
