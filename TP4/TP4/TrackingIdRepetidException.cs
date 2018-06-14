using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class TrackingIdRepetidException :Exception
    {
        #region Constructores

        public TrackingIdRepetidException(string mensaje) 
            : base(mensaje)
        { 
        }

        public TrackingIdRepetidException(string mensaje, Exception inner)
            : base(mensaje, inner)
        { 
        }

        #endregion
    }
}
