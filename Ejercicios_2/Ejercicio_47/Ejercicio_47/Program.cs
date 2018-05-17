using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura(1);
            Factura f2 = new Factura(2);
            Recibo r = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            c += f;
            c += f2;
            c += r;
            c += r2;
        }
    }
}
