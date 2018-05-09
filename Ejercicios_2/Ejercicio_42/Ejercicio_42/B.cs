using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class B
    {
        public B()
        {
            try
            {
                A claseA = new A();
            }
            catch (Exception e) {
                throw new UnaException("Error al crear A ", e);
            }

        }
   
    }
}
