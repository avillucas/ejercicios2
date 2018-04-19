using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion bob = new Camion(8, 2, Colores.Rojo, 4, 4000);
            Automovil rayo = new Automovil(4, 2, Colores.Azul, 6, 1);
            Moto bill = new Moto(2, 0, Colores.Negro, 5000);
        }
    }
}
