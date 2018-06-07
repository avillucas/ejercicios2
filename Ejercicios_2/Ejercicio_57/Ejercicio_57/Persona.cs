using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Ejercicio_57
{
    public class Persona
    {        
        private static string filePath ;
        private string nombre;
        private string apellido;

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

        #region "Constructores"
        
        static Persona()
        {
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "persona.data";
        }

        public Persona()
        { 
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion
        
        #region "Metodos"

   

        public static void Guardar(Persona persona)
        {
            try{                
                XmlTextWriter writer = new XmlTextWriter(filePath, null);
                XmlSerializer ser =  new XmlSerializer(typeof(Persona));                                                     
                ser.Serialize(writer, persona);             
                writer.Close();                
             }
             catch(Exception e)
             {
                 throw e;
             }

        }

        public static Persona Leer()
        {
            try
            {                
                XmlTextReader reader= new XmlTextReader(filePath);
                XmlSerializer ser = new XmlSerializer(typeof(Persona));                
                Persona persona = (Persona)ser.Deserialize(reader);
                reader.Close();
                return persona;
            }
            catch (Exception e) 
            {
                throw e;
            }
            
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("nombre: {0}, apellido {1}", this.nombre, this.apellido);
            return st.ToString();
        }

        #endregion
    }
}
