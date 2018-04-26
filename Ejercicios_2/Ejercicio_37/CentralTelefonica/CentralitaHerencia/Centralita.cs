using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        /// <summary>
        /// TODO
        /// </summary>
        public float GananciasPorLocal
        {
            get {
                return CalcularGanancia(Llamada.TipoDeLlamada.Local);
            }
        }

        public float GanaciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoDeLlamada.Provincial);
            }
        }

        public float GanaciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoDeLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        private Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private void AgregarLlamada(Llamada nuevaLlamada) 
        {       
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará
        /// el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local,
        /// Provincial o de Todas según corresponda).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoDeLlamada tipo)
        {
            float ganacia = 0;
            foreach (Llamada llamada in listaDeLlamadas) {
                if (llamada is Local && ( tipo == Llamada.TipoDeLlamada.Local || tipo == Llamada.TipoDeLlamada.Todas)) {
                    ganacia += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial && (tipo == Llamada.TipoDeLlamada.Local || tipo == Llamada.TipoDeLlamada.Todas))
                {
                    ganacia += ((Provincial)llamada).CostoLlamada;
                }                
            }
            return ganacia;
        }


        public override string ToString () 
        {
            StringBuilder st = new StringBuilder();                        
            st.AppendFormat("\n razon social {0} ganancia total {1} Ganacias Locales {2} Ganancias Provinciales {3} ", razonSocial, GanaciasPorTotal , GananciasPorLocal,GanaciasPorProvincial);
            foreach(Llamada llamada in  listaDeLlamadas){
                st.AppendFormat("\n llamado {0} ", llamada.ToString());
           }
            return st.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            foreach (Llamada posibleLlamada in central.listaDeLlamadas)
            {
                if (posibleLlamada == (Llamada)llamada) {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {            
            return !(central == llamada);
        }

        ///
        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if (central == llamada)
            {
                throw new CentralitaException("La llamada "+llamada.NroOrigen+"=>"+llamada.NroDestino+" ya se encuentra en la central","Centralita", "operator +");
            }
            central.AgregarLlamada(llamada);
            return central;
        }

    }
}
