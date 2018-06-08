using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_62
{
    class Program
    {
        private static Thread hilo1 ;        
        private static Thread hilo2 ;
        private static Thread hilo3 ;
        
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("tito");
            negocio.Clientes.Add("pedro");
            negocio.Clientes.Add("pablo");
            negocio.Clientes.Add("carlos");
            negocio.Clientes.Add("david");
            negocio.Clientes.Add("silvio");
            negocio.Clientes.Add("carloncho");
            negocio.Clientes.Add("patricia");
            hilo1 = new Thread(negocio.AsignarCaja);            
            hilo2 = new Thread(caja1.AtenderClientes);
            hilo2.Name = "Caja 1";
            hilo3 = new Thread(caja2.AtenderClientes);
            hilo3.Name = "Caja 2";
            //            
            hilo1.Start();
            hilo1.Join();
            hilo2.Start();
            hilo3.Start();            
    
        }
    }
}
