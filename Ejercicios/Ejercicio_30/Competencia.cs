using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        
        
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        /// <summary>        
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas totales</param>
        /// <param name="cantidadCompetidores">Cantidad de competidores</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        /// <summary>
        /// Agrega un auto a la competencia
        /// </summary>
        /// <param name="c">Competencia</param>
        /// <param name="a">Auto a agregar en la competencia</param>
        /// <returns></returns>
        public static bool operator +(Competencia c, AutoF1 a)
        {
            //si queda espacio
            if (c.cantidadCompetidores >= c.competidores.Count)
            {
                return false;
            }
            //si el usuario no esta
            if (c == a)
            {
                return false;
            }
            //agregarlo
            c.competidores.Add(a);
            //
            a.SetEnCompetencia(true);
            Random combustible = new Random();
            a.SetCantidadCombustible((short) combustible.Next(15,100));
            a.SetVueltasRestantes(c.cantidadVueltas);
            return true;
        }

        /// <summary>
        /// Indica si un auto esta en la competencia
        /// </summary>
        /// <param name="c">Competencia</param>
        /// <param name="a">Auto</param>
        /// <returns></returns>
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }

        /// <summary>
        /// Indica si un auto NO esta en la competencia
        /// </summary>
        /// <param name="c">Competencia</param>
        /// <param name="a">Auto</param>
        /// <returns></returns>
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !c.competidores.Contains(a);
        }
    }
}
