using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    class MiLista<T> : IEnumerable
    {
        private T[] items;

        /// <summary>
        /// devuelve la cantidad de numeros
        /// </summary>
        public int Count
        {
            get
            {
                return this.items.Count();
            }
        }
        /// <summary>
        /// Inicializa Mi Lista
        /// </summary>
        public MiLista()
        {
            items = new T[0];
        }

        /// <summary>
        /// TODO COMPLETAR
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
           // int cantidadAnterior = this.items.Count();            
            Array.Resize(ref this.items,  this.items.Length +1 );
            this.items[this.items.Length-1] = item;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item) 
        {
            //buscar el valor en el array mover todos los demas un espacio para atras de existir 
            //encontrar la posicion 
            
            int cantidadInicial = this.items.Count();
            int indiceEncontrado = -1;
            for (int i = 0; i < this.items.Count(); i++) 
            {
                if (this.items[i].Equals(item)) {
                    indiceEncontrado = i;
                }
                //de haberse encontrado 
                if (indiceEncontrado != -1 )
                {
                    //determinar si no es el ultimo
                    if (cantidadInicial > (i + 1))
                    {
                        //mover al siguiente un espacio para atras
                        this.items[i] = this.items[i + 1];
                    }                     
                }
            }
            if (indiceEncontrado != -1)
            {
                //eliminar el ultimo espacio
                Array.Resize(ref this.items, (cantidadInicial - 1));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
          //  return this.items.AsEnumerable();
        }
        

        public MiListaEnum<T> GetEnumerator()
        {
            return new MiListaEnum<T>(this.items);
        }
         
    }
}
