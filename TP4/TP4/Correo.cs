using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP4
{
    class Correo
    {
        List<Thread> mockPaquetes;
        List<Paquete> paquetes;
        
        public List<Paquete> Paquetes
        {
            get {
                return this.paquetes;
            
            }
            set {
                this.paquetes = value;
            }
        }

        public Correo() 
        {
            this.paquetes = new List<Paquete>();
        }

        public void FinEntrega()
        {
            throw new NotImplementedException();
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            throw new NotImplementedException();
        }

        public static Correo operator + ( Correo c, Paquete p)
        {
            throw new NotImplementedException();
        }
    }
}
