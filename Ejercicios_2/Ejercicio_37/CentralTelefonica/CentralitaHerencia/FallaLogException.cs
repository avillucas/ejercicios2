using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class FallaLogException : Exception
    {
<<<<<<< HEAD
        public FallaLogException(string errorString, Exception internalError)
            :base(errorString,internalError)
        {}
=======
        public FallaLogException(string message, Exception internalException) 
        : base(message, internalException)
        {
        }
>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
    }
}
