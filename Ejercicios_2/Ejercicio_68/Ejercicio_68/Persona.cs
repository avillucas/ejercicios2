using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{    
    delegate void DelegadoString(string msg );

    class Persona
    {
        private string nombre;
        private string apellido;

        public string Apellido 
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get 
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        #region Constructores
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion
        #region Metodos
        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\t Nombre: {0} \n\t Apellido: {1} ",this.nombre, this.apellido);
            return st.ToString();
        }
        #endregion

    }
}
