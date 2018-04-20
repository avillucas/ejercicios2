using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;
        
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo): base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;            
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        /// <summary>
        /// CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
        /// de la misma.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto() 
        {
            return Duracion* costo;
        }

        public override string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n Nro de origen {0}  llamando a Nro de destino {1} por una duracion de {2} con un costo de {3}",NroOrigen, NroDestino, Duracion,CostoLlamada);
            return st.ToString();
        }
    }
}
