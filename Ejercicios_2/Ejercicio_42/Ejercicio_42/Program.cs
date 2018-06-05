using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace Ejercicio_42
{
    class Program
    {
        /// <summary>
        /// Modificar en el Main donde se captura la excepción. Quitar los Console.WriteLine y guardar
        /// todos los datos del error en un archivo de texto, cuyo nombre será la fecha y hora actual        /// como indica este ejemplo: '20171012-1316.txt' (año mes día – hora minutos).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string filePath = dt.Year + dt.Month + dt.Day + "-" + dt.Hour + dt.Minute + ".txt";
            try
            {
                C claseC = new C();
            }
            catch (Exception e)
            {   
                ArchivoTexto.Guardar(filePath, getTrace(e));
           
            }
            Console.Write(ArchivoTexto.Leer(filePath));
            Console.ReadKey();
        }

        public static string getTrace(Exception e) { 
            StringBuilder st = new StringBuilder();            
            do
            {
                st.AppendLine(e.Message);                
                e = e.InnerException;
            } while (!Object.ReferenceEquals(e, null));
            return st.ToString();
        }
    }
}
