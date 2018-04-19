using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Libro
    {

        private List<string> paginas;
        // Defino el indexador
        public string this[int i]
        {
            get {                
                if( i < paginas.Count )
                {
                    return paginas[i]; 
                } 
                return "";                
            }
            set {
                if (i >= paginas.Count)
                {
                    paginas.Add(value);
                }
            }
        }

        public Libro() { 
            paginas = new List<string>();
        }

    }
}
