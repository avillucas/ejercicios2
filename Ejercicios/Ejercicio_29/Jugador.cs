using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        /// <summary>
        /// El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
        /// </summary>
        /// <returns></returns>
        public float GetPromedioGoles() 
        {
            //para evitar la division por 0
            if (partidosJugados > 0)
            {
                promedioGoles = totalGoles / partidosJugados;
            }
            return promedioGoles;
        }

        /// <summary>
        /// Todos los datos estadísticos del Jugador se inicializarán en 0 dentro del constructor privado.
        /// </summary>
        private Jugador()
        {
            promedioGoles = 0;
            partidosJugados = 0;
            totalGoles = 0;
        }

        /// <summary>        
        /// Inicializa solo con el nombre
        /// </summary>
        /// <param name="dni">Dni del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        public Jugador(int dni, string nombre) 
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        /// <summary>
        /// TODO ARMAR
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
        public string MostrarDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\tdni :{0}", dni);
            st.AppendFormat("\n\tnombre :{0}", nombre);
            st.AppendFormat("\n\tpartidosJugados :{0}", partidosJugados);
            st.AppendFormat("\n\ttotal de goles :{0}", totalGoles);
            st.AppendFormat("\n\tpromedio de goles :{0}", this.GetPromedioGoles());
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
