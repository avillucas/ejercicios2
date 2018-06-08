using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_62
{
    class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes{
            get {
                return filaClientes;
            }
        }

        #region constructores
        public Caja()
        {

            this.filaClientes = new List<string>();

        }
        #endregion
        #region metodos
        /// <summary>
        ///  El método AtenderClientes deberá recorrer la fila de clientes e ir imprimiendo el nombre del
        ///  cliente que se está atendiendo junto  con el nombre de la caja
        /// </summary>
        public void AtenderClientes()
        {
           
            string nombreCaja = Thread.CurrentThread.Name;
            foreach (string cliente in this.filaClientes) 
            {
                Console.WriteLine("{0} esta siendo atendido en la {1}",cliente, nombreCaja);
                Thread.Sleep(2000);
            }
            
        }
        #endregion       
    }    
}
