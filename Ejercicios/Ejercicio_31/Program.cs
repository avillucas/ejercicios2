using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {

            Negocio adidas = new Negocio("Adidas");
            Cliente tito = new Cliente(1, "Tito");
            Cliente susana = new Cliente(2, "Susana");
            Cliente nora = new Cliente(3, "Nora");
            Cliente susana2 = new Cliente(2, "Susana");
            Cliente tato = new Cliente(4, "Tato");
            if (adidas + tito) {
                Console.WriteLine("Tito esta en la cola de Adidas");
            }
            if (adidas + susana)
            {
                Console.WriteLine("Susana esta en la cola de Adidas");
            }
            if (adidas + nora)
            {
                Console.WriteLine("Nora esta en la cola de Adidas");
            }
            if (adidas + susana2)
            {
                Console.WriteLine("Susana pudo entrar de nuevo en la cola de Adidas");
            }
            else {
                Console.WriteLine("Susana NO pudo entrar de nuevo esta en la cola de Adidas");
            }
            if (adidas + tato)
            {
                Console.WriteLine("Tato esta en la cola de Adidas");
            }
            //atender            
            while(~adidas) {
                Console.WriteLine("Adidas Termino la atencion del numero");
            }            
            Console.ReadKey();


        }
    }
}
