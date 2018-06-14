using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    class TrackingIdRepetidoException : Exception
    {
        #region Constructores
        public TrackingIdRepetidoException(string mensaje) : base(mensaje)
        {
        }

        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }

        #endregion
    }
}
