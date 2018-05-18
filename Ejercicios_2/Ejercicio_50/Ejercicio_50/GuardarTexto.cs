﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class GuardarTexto<T, V> : IGuardar<T, V>
    {
        bool IGuardar<T, V>.Guardar(T obj)
        {
            return true;
        }

        V IGuardar<T, V>.Leer()
        {
            return (V) Convert.ChangeType("Texto Leído",typeof(V));
        }
    }
}
