using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        public DirectorTecnico(string nombre): base(nombre)
        {            
        }

        public DirectorTecnico(int dni, string nombre, DateTime fechaDeNacimiento) : base(dni, nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.dni != d2.dni);
        }

        
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.dni == d2.dni);
        }

        /// <summary>
        /// MostrarDatos retornará una cadena de string con todos los datos y estadística del Director Tecnico
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\tDNI :{0}", dni);
            st.AppendFormat("\n\tNombre :{0}", nombre);
            st.AppendFormat("\n\tFecha de Nacimiento :{0}", fechaDeNacimiento);
            return st.ToString();
        }
    }
}
