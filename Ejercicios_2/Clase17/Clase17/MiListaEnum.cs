using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    class MiListaEnum<R>: IEnumerator
    {
        private R[] items;

        int position;
        
        private MiListaEnum() 
        {
            this.position = -1;
        }

        public MiListaEnum(R[] items):this()
        {            
            this.items = items;
        }

        public bool MoveNext()
        {
            position++;
            return (position < items.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public R Current
        {
            get
            {
                try
                {
                    return this.items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
