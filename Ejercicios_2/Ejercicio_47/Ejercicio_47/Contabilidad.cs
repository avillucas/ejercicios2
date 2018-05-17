using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Contabilidad<T, U>
        where T : Factura
        where U : Recibo 
    {
        private List<T> egresos;
        private List<U> ingresos;
                
        #region "Constructores"        

        /// <summary>
        /// Crea una contabilidad
        /// </summary>
        public Contabilidad()
        {
            this.ingresos = new List<U>();
            this.egresos = new List<T>();
        }
            

        #endregion
        /// <summary>
        /// Agrega un egreso a contabilidad
        /// </summary>
        /// <param name="c">Contabilidad a la que agregar el egreso</param>
        /// <param name="egreso">Egreso agregado</param>
        /// <returns></returns>
        public static Contabilidad<T, U>  operator +(Contabilidad<T, U> c, T egreso) 
        {
            c.egresos.Add(egreso);
            return c;
        }

        #region "operadores"
        /// <summary>
        /// Agregar ingreso a contabilidad
        /// </summary>
        /// <param name="c">Contabilidad</param>
        /// <param name="ingreso">Ingreso a agregar</param>
        /// <returns></returns>
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        #endregion
    }
}
