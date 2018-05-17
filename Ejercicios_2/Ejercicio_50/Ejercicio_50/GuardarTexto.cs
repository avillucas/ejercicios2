using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class GuardarTexto : IGuardar
    {
         bool IGuardar.Guardar(T obj){
             return true;
         }
         
        V IGuardar.Leer() {
             return "Texto Leído";
         }
    }
}
