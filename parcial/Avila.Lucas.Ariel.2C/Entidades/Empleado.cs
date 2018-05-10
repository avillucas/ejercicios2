using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado :Persona
    {
        private Departamentos departamento;
        private short piso;

        /// <summary>
        ///  retornará un string con el siguiente formato: XºZ, siendo X el piso que se encuentra cursando y Z el departamento en letra (A, B, C, D o E).
        /// </summary>
        public string PisoDepartamento
        {
            get {
                return piso.ToString() + "º" + departamento.ToString();
            }
        }

        #region "Constructores"
        /// <summary>
        /// Crea un empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        /// <param name="piso"></param>
        /// <param name="departamento"></param>
        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento): base(nombre, apellido,documento)
        {
            this.piso = piso;
            this.departamento = departamento;
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
            st.AppendFormat("\n\t Departamento :{0} ", PisoDepartamento);            
            return st.ToString();
        }

        /// <summary>
        /// TODO COMPLETAR
        /// ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato XX-XXXX-X 
        /// siendo las X números. Caso contrario retornará false y no se asignará el documento, siguiendo
        /// luego con el curso normal de la aplicación.        
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            int n1 ;
            int n2;
            int n3;
            int n4;
            int n5;
            int n6;
            int n7;
            bool ok1 = int.TryParse(doc.Substring(0,1), out n1);
            bool ok2 = int.TryParse(doc.Substring(1, 1), out n2);
            bool ok3 = doc.Substring(2,1) == "-";
            bool ok4 = int.TryParse(doc.Substring(3, 1), out n3);
            bool ok5 = int.TryParse(doc.Substring(4, 1), out n4);
            bool ok6 = int.TryParse(doc.Substring(5, 1), out n5);
            bool ok7 = int.TryParse(doc.Substring(6, 1), out n6);
            bool ok8 = doc.Substring(7, 1) == "-";
            bool ok9 = int.TryParse(doc.Substring(8, 1), out n7);
            if (
                ok1
                && ok2
                && ok3
                && ok4
                && ok5
                && ok6
                && ok7
                && ok8
                && ok9
                )
            {
                return true;
            }
            
            return false;
        }

        #endregion
    }
}
