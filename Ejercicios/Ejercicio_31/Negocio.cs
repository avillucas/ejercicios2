using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {                
                return this.clientes.Dequeue();
            }
            set
            {
               //TODO ver como hacer esto mejor
               if(this != value) {
                    if (this + value) {
                        bool funciono = true;
                    }
                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;            
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !n.clientes.Contains(c);
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
            {
                return false;
            }
            n.clientes.Enqueue(c);            
            return true;
        }

        public static bool operator ~(Negocio n)
        {
            try
            {
                Cliente siguienteCliente = n.Cliente;
                return n.caja.Atender(siguienteCliente);
            }
            catch (Exception) {
                return false;
            }
           
        }
    }
}
