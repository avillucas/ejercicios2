using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Recibo : Documento
    {
        #region "Constructores"

        /// <summary>
        /// Crea un recibo con numero numero
        /// </summary>
        /// <param name="numero"></param>
        public Recibo(int numero) :base(numero)
        { 
        }

        /// <summary>
        /// Crea un recivo en 0
        /// </summary>
        public Recibo()
            : this(0)
        {
        }


        #endregion
    }
}
