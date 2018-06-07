using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona persona = new Persona("nombre", "apellido");
                Persona.Guardar(persona);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            try
            {
                Persona persona2 = Persona.Leer();
                Console.Write(persona2.ToString());                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
