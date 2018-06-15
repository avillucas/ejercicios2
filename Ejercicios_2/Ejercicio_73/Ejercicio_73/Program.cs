using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_73
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do{
                long numero ;
                string strNumero;
                Console.Write("Ingrese un nùmero y presione enter o escriba EstariaBuenoSalir para salir :");
                strNumero = Console.ReadLine();
                if(long.TryParse(strNumero, out numero))
                {
                    Console.WriteLine("Numero de {0}",numero.CantidadDeDigitos());
                }
                else if (strNumero == "EstariaBuenoSalir")
                {
                    salir = true;
                }
                else {
                    Console.Clear();
                }
            }while(!salir);
        }
    }
}
