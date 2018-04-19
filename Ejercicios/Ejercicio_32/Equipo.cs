using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        
        /// <summary>
        /// La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
        /// </summary>
        private Equipo() 
        { 
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Crea el equipo
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="nombre"></param>
        public Equipo(short cantidad, string nombre):this()
        {            
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        /// <summary>
        ///  La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
        ///  aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
        ///  cantidadDeJugadores.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator +(Equipo e, Jugador j) 
        {
            // la cantidad de jugadores no supere el límite establecido por el atributo  cantidadDeJugadores.
            if (e.jugadores.Count >= e.cantidadDeJugadores) 
            {
                return false;
            }
            if(e.jugadores.Contains(j))
            {
                return false;
            }
            e.jugadores.Add(j);
            return true;
        }

    }
}
