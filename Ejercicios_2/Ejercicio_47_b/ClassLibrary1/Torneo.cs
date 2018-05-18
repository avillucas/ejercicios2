using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Torneo<T>        
        where T:Equipo
    {
        private List<T> equipos;
        private string nombre;


        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach (T equipo in t.equipos) 
            {
                if (equipo == e) return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if (t == e) return t;
            t.equipos.Add(e);
            return t;
        }

        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("Torneo: {0} \n Equipos: ");
            foreach(T equipo in this.equipos)
            {
                st.AppendLine(equipo.ToString());
            }
            return st.ToString();
        }

        /// <summary>
        /// TODO COMPLETAR 
        /// </summary>
        /// <param name="?"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        private string CalcularPartido(T,T)
        {
            Random
            return "[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”;
        }

    }
}
