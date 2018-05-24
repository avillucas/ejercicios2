using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoLibrary
{
    /// <summary>
    /// _nominaEmpleados del tipo lista de empleados, privado y de instancia.
    /// _razonSocial del tipo string, privado y de instancia. Generar Property.
    /// _direccion del tipo string, privado y de instancia. Generar Property.
    /// _ganancias del tipo float, privado y de instancia. Generar Property.
    /// Codificar un constructor privado por defecto. Este será el único lugar donde se instanciará la nómina de empleados.
    /// Codificar otro constructor que reciba como parámetro la razón social, dirección y ganancias de la Empresa.
    /// Sobrecarga del operador + (Empresa, Empleado). Si el empleado no existe, lo agrega a la nómina.    
    /// -----------------------------------
    /// </summary>
    public class Empresa
    {
        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganacias;

        #region "Constructores"
        
        private Empresa() 
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias)
            :this()
        {
        }
        #endregion
        #region "Operadores"

        public static bool operator !=(Empresa e, Empleado emp)
        {
            return !(e == emp);
        }

        public static bool operator == (Empresa e, Empleado emp)
        {
           foreach (Empleado ep in e.nominaEmpleados)
            {
                if (ep == emp) 
                {
                    return true;
                }
            }
            return false;
        }

        public static Empresa operator +(Empresa e, Empleado emp)
        {
            if (e != emp)
            {
                e.nominaEmpleados.Add(emp);
            }
            return e;
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Método MostrarEmpresa() : string. Retornará la lista de empleados con el siguiente formato:
        /// La empresa [razón social] sita en la calle [dirección] cuenta con ganancias por [ganancias] y con [cantidad de empleados] empleados:
        /// NOMBRE: [nombre] 
        /// APELLIDO: [apellido]
        /// LEGAJO: [legajo]
        /// SALARIO: $[salario]
        /// </summary>
        /// <returns></returns>
        public string MostrarEmpresa() {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:",this.razonSocial,this.direccion,this.ganacias,this.nominaEmpleados.Count());
            st.AppendLine("");
            foreach (Empleado e in this.nominaEmpleados)
            {
                st.AppendFormat("\n{0}",e.Mostrar());
                st.AppendLine("-----------------------");
            }

            return st.ToString();
        }
        #endregion
    }
}
