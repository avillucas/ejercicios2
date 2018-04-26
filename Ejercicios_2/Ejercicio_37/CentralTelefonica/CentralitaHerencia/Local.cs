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
        
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
        {
            this.nroOrigen = nroOrigen;
            this.duracion = duracion;
            this.nroDestino = nroDestino;
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

        protected override string Mostrar()
        {
            string baseStr = base.Mostrar();
            StringBuilder st = new StringBuilder();
            st.AppendLine(baseStr);
            st.AppendFormat("\nCon un costo de {0}",CostoLlamada);
            return st.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
