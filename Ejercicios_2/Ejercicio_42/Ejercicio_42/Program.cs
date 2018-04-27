using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                C claseC = new C();
            }
            catch (Exception e)
            {
                Console.Write(getTrace(e));
                Console.ReadKey();
            }
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
