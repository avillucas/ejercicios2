using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public enum TipoDeLlamada {
            Local ,
            Provincial, 
            Todas
        }
        
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n Nro de origen {0}  llamando a Nro de destino {1} por una duracion de {2}",NroOrigen, NroDestino, Duracion);
            return st.ToString();
        }

        /// <summary>
        ///  OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para
        ///  ordenar una lista de llamadas de forma ascendente.
        /// </summary>
        /// <remarks>Revisar </remarks>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2) {
            if (llamada1.Duracion == llamada2.Duracion)
                return 0;
            if(llamada1.Duracion > llamada2.Duracion) 
                return 1;
            return -1;
        }

    }
}
