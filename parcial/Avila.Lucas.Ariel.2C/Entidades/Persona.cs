using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {        
        private string apellido;
        private string documento;
        private string nombre;

        public string Apellido
        {
            get 
            {
                return apellido;
            }
        }

        public string Documento
        {
            get
            { 
                return documento;
            }
            set 
            {
                if (ValidarDocumentacion(value))
                {
                    documento = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        #region "Constructores"
        
        /// <summary>
        /// Crea una persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        #endregion



        #region "Metodos"

        /// <summary>
        /// Retorna  los datos de la persona
        /// </summary>
        /// <returns></returns>
        public virtual string ExponerDatos()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\t-Documento :{0} ", documento);
            st.AppendFormat("\n\t-Nombre y Apellido :{0} {1}", nombre, apellido);            
            return st.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);

        #endregion

    }
}
