using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Jugador : Persona
    {
      
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
        }

      
    

        public float PromedioGoles
        {
          get
            {  //para evitar la division por 0
                if (partidosJugados > 0)
                {
                    promedioGoles = (float ) totalGoles / partidosJugados;
                }
                return promedioGoles;
            }
        }

      
        /// <summary>        
        /// Inicializa solo con el nombre
        /// </summary>
        /// <param name="dni">Dni del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        public Jugador(int dni, string nombre) :base(dni,nombre)
        {
            promedioGoles = 0;
            partidosJugados = 0;
            totalGoles = 0;
        }

        /// <summary>        
        /// </summary>
        /// <param name="nombre"> Nombre del jugador</param>
        /// <param name="totalGoles">Total de goles convertidos</param>
        /// <param name="totalPartidos">Total de partidos jugados</param>
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        /// <summary>
        /// MostrarDatos retornará una cadena de string con todos los datos y estadística del Jugador.
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\tDNI :{0}", dni);
            st.AppendFormat("\n\tNombre :{0}", nombre);
            st.AppendFormat("\n\tPartidosJugados :{0}", partidosJugados);
            st.AppendFormat("\n\tTotal de goles :{0}", totalGoles);
            st.AppendFormat("\n\tPromedio de goles :{0:00.00}", PromedioGoles);
            return st.ToString();
        }

        /// <summary>
        /// Dos jugadores serán distintos si  no tienen el mismo DNI.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator != ( Jugador j1, Jugador j2){
            return (j1.dni != j2.dni);
        }

        /// <summary>
        /// Dos jugadores serán iguales si tienen el mismo DNI.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }
        
    }
}
