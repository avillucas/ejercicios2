using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace IO
{
    public static class ArchivoTexto
    {
        /// <summary>
        /// El método Guardar agregará información al archivo de texto ubicado en la ruta pasada como 
        /// parámetro.También recibirá un string con la información a guardar
        /// </summary>
        /// <param name="filePath"></param>
        public static void Guardar(string filePath, string content)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine(content);
            }            
        }

        /// <summary>
        /// El método Leer retornará el contenido del archivo ubicado en la ruta pasada como
        /// parámetro.En caso de no existir, lanzará la excepción de sistema FileNotFoundException
        /// </summary>
        /// <param name="filePath"></param>
        public static string Leer(string filePath)
        {
            string contenido;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
                {
                    contenido = file.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return contenido;

        }
    }
}
