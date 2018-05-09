﻿using System;
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


        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
        /// y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar() 
        {
            StringBuilder st = new StringBuilder();            
            st.AppendFormat("\n razon social {0} ganancia total {1} Ganacias Locales {2} Ganancias Provinciales {3} ", razonSocial, GanaciasPorTotal , GananciasPorLocal,GanaciasPorProvincial);
            foreach(Llamada llamada in  listaDeLlamadas){
                st.AppendFormat("\n llamado {0} ", llamada.Mostrar());
           }
            return st.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}