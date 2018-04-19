using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Persona
    {
        protected long dni;
        protected string nombre;

        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
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

        public override string MostrarDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\tDNI :{0}", dni);
            st.AppendFormat("\n\tNombre :{0}", nombre);            
            return st.ToString();
        }

        public Persona(string nombre)
        {
            Nombre = nombre;            
        }

        public Persona(long dni, string nombre):this(nombre)
        {            
            Dni = dni;
        }
    }
}
