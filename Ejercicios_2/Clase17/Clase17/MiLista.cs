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
            items = new T[1];
        }

        /// <summary>
        /// TODO COMPLETAR
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            int nuevaCantidad = this.items.Count()+1;
            Array.Resize(ref this.items, nuevaCantidad);            
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item) 
        {
            int nuevaCantidad = this.items.Count() -1 ;
            Array.Resize(ref this.items, nuevaCantidad);            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MiListaEnum<T> GetEnumerator()
        {
            return new MiListaEnum<T>(this.items);
        }
    }
}
