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

        public enum Franja
        {            
            Franja_1,
            Franja_2,
            Franja_3
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino): base(duracion, destino, origen)
        {
            this.franja = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        /// <summary>
        /// TODO  revisar si devuelve el valor o otro 
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            //Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
            double coeficiente = 0 ;
            switch(franja){
                case Franja.Franja_1: 
                    coeficiente = 0.99; 
                break;
                case Franja.Franja_2:
                    coeficiente = 1.25;
                break;
                case Franja.Franja_3:
                    coeficiente = 0.66;
                break;
            }
            return (float)(Duracion * coeficiente);
        }

        public override string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n Nro de origen {0}  llamando a Nro de destino {1} por una duracion de {2} con un costo de {3} por la franja horaria {4}", NroOrigen, NroDestino, Duracion, CostoLlamada,franja.ToString());
            return st.ToString();
        }


    }
}
