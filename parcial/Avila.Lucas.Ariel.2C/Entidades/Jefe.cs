using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe:Persona
    {
        private DateTime fechaIngreso;
        
        /// <summary>
        /// devolverá la cantidad de tiempo, en días, desde la fecha de ingreso del jefe hasta la actualidad
        /// </summary>
        public int Antiguedad
        {
            get 
            {                 
                DateTime fechaActual = DateTime.Now;
                return (int) (fechaActual - fechaIngreso).TotalDays;
            }
        }

        #region "Constructores"
        public Jefe(string nombre, string apellido, string documento)  : this(nombre, apellido, documento, DateTime.Now)
          
        { 

        }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        #endregion


        #region "Metodos"
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat(base.ExponerDatos());
            st.AppendFormat("\n\t Antigüedad :{0} ", Antiguedad);
            return st.ToString();
        }

        /// <summary>        
        /// ValidarDocumentacion dará como válido cuando tenga 8 caracteres.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            return (doc.Length  == 8);
        }

        #endregion

    }
}
