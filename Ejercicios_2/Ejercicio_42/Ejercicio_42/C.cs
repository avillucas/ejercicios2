using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class C
    {
        public C()
        {
            try
            {
                B claseB = new B();
            }
            catch (Exception e)
            {
                throw new MiException("Error al crear B ", e);
            }
        }
    }
}
