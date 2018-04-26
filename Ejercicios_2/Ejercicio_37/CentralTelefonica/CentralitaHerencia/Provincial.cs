using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franja;

        
        /// <summary>
        /// Costos de las franjas expresadas en centavos Franja_1: 99, Franja_2: 125 y Franja_3: 66.
        /// </summary>
        public enum Franja
        {            
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {
            this.duracion = duracion;
            this.nroOrigen = origen;
            this.nroDestino = destino;
            this.franja = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        /// <summary>
        
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            //Se puede hacer esto directamente con enumerados
            //Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
            double coeficiente = (int)franja / 100;            
            return (float)(Duracion * coeficiente);
        }

        protected override string Mostrar()
        {
            string baseStr = base.Mostrar();
            StringBuilder st = new StringBuilder();
            st.AppendLine(baseStr);
            st.AppendFormat("\n Con un costo de {0} por la franja horaria {1}", CostoLlamada,franja.ToString());
            return st.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
    }
}
