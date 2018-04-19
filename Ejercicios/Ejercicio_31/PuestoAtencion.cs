using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        const int tiempoAtencion = 2000;
        static private int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }            
        }
        
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto )
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {            
            Thread.Sleep(tiempoAtencion);
            return true;
        }
    }
}
