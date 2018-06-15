using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_73
{
    public static class LongExtension
    {
        public static string CantidadDeDigitos(this long numeroLong)
        {
            int cantidad = numeroLong.ToString().Length;
            return (cantidad > 1) ? String.Format("{0} dìgitos",cantidad.ToString()) : String.Format("{0} dìgito",cantidad.ToString());
        }
    }
}
