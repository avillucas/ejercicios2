using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class A
    {
        public A() {
            try
            {
                generadorDeInfinito();
            }
            catch (DivideByZeroException e) {
                throw e;
            }
        }

        private static double generadorDeInfinito()
        {
            int a = 1 - 1;
            return 1/a;
        }

    }
}
