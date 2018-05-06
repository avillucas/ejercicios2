using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    abstract class Sobreescrito
    {

        protected string miAtributo;

        public Sobreescrito()
        {
            miAtributo = "Probar abstractos";
        }

        protected abstract string MiPropiedad { };
        protected abstract string MiMetodo();



        public override string ToString() {
            return "¡Este es mi método ToString sobreescrito!";
        }

        /// <summary>
        /// Sobreescribir el método Equals para que retorne true si son del mismo tipo 
        /// (objetos de la misma clase), false en caso contrario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            return false;            
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
