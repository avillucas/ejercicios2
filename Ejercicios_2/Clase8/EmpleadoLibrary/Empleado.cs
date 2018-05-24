using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoLibrary
{
    /// <summary>
    /// _nombre del tipo string, privado y de instancia
    /// _apellido del tipo string, privado y de instancia
    /// _legajo del tipo string, privado y de instancia
    /// _puesto del tipo EPuestoJerarquico, privado y de instancia
    /// _salario del tipo entero, privado y de instancia
    /// Generar un constructor de instancia para cargar todos estos atributos.
    /// Sobrecarga del operador ==. Dos empleados son iguales si comparten el mismo legajo.
    /// Método Mostrar() deberá retornar un string con los datos del empleado.
    /// </summary>
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private EPuestoJerarquico puesto;
        private int salario;

        #region "Contructores"
        
        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
            this.salario = salario;
        }

        #endregion
        #region "Operadores"
        public static bool operator +(Empleado e, Empleado e1)
        {
            return (e.legajo == e1.legajo);
        }
        #endregion
        #region "Metodos"
        /// NOMBRE: [nombre] 
        /// APELLIDO: [apellido]
        /// LEGAJO: [legajo]
        /// SALARIO: $[salario]
        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\tNOMBRE: {0}\n\tAPELLIDO: {1}\n\tLEGAJO: {2}\n\tSALARIO: ${4}", this.nombre, this.apellido, this.legajo, this.salario.ToString());
            return st.ToString();
        }
        #endregion
    }
}
