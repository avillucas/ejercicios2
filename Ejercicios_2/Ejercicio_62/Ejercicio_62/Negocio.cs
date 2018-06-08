using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_62
{
    class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        #region Propiedades
        public Caja Caja1 
        {
            get 
            {
                return caja1;
            }
        }
        
        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return clientes;
            }
        }
        #endregion

        #region Constructores
        public Negocio( Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// El método AsignarCaja deberá imprimir el mensaje "Asignando cajas..." cuando sea
        /// invocado, recorrer la lista de clientes y asignar a cada cliente en la fila de la caja que menos
        /// clientes tenga en ese momento.
        /// </summary>
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");            
            foreach(string cliente in this.clientes){
                if (caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(cliente);
                }
                else 
                {
                    caja2.FilaClientes.Add(cliente);
                }
                Console.WriteLine("{0} asignado",cliente);
                //clientes.Remove(cliente);
                Thread.Sleep(1000);
            }
        }        
        #endregion

    }
}
