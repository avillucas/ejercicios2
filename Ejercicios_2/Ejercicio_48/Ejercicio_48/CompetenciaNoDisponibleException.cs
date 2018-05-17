using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class CompetenciaNoDisponibleException :Exception
    {
        private string nombreClase;
        private string nombreMetodo;
                
        public string NombreClase
        {
            get 
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo):base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            //return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
            StringBuilder st = new StringBuilder();
            st.AppendFormat("Excepción en el método {0} de la clase {1}", this.nombreMetodo, this.nombreClase);
            st.AppendFormat("\n{0}", this.Message);
            Exception e = this.InnerException;
            do
            {
                st.AppendFormat("\n\t{0}",e.Message);
                e = e.InnerException;
            } while (!Object.ReferenceEquals(e, null));
            return st.ToString();
        }
    }
}
