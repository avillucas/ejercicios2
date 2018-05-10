using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;

        /// <summary>        
        /// </summary>
        /// <returns></returns>
        public string PisoDepartamento
        {
            get
            {
                return piso.ToString() + "º" + departamento.ToString();
            }
        }

        #region "Constructores"

        private Oficina()
        { 
            this.empleados = new List<Empleado>();
        }
        
        
        /// <summary>
        /// Crea una Oficina
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="departamento"></param>
        /// <param name="jefe"></param>
        public Oficina(short piso, Departamentos departamento, Jefe jefe):this()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }

        #endregion
        #region "Operadores"
        public static explicit operator string(Oficina o) 
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\nLa oficina ubicacda en el deparamento {0} tiene {1} empleados ", o.PisoDepartamento, o.empleados.Count);
            st.Append("\nJEFE:");
            st.AppendFormat("\n {0}",o.jefe.ExponerDatos());
            st.Append("\nEMPLEADOS:");            
            foreach(Empleado empleado in o.empleados)
            {
                st.AppendFormat("\n{0}", empleado.ExponerDatos());
            }
            return st.ToString();
        }

        /// <summary>
        ///  informará true si el empleado pertenece al mismo Piso y División que el oficina.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Oficina o, Empleado e)
        {
            return (e.PisoDepartamento == o.PisoDepartamento);            
        }

        public static bool operator !=(Oficina o, Empleado e)
        {
            return !(o == e);
        }

        /// <summary>
        ///  agregará al empleado a la oficina siempre y cuando su Piso y División coincidan.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Oficina operator +(Oficina o, Empleado e) 
        {
            if (o == e) {
                o.empleados.Add(e);
            }
            return o;
        }

        #endregion

    }
}
