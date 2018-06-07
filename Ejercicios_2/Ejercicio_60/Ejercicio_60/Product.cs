using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_60
{
    public class Product
    {
        private int id;
        //TODO VALIDAR 50
        private string name;
        
        public int Id
        {
            get 
            {
                return id;
            }
            set 
            {                
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new InvalidOperationException("El nombre no puede tener mas de 50 caracteres");
                }
                name = value;
            }
        }


        public Product(int id, string nombre)
        {
            this.id = id;
            this.name = nombre;
        }

    }
}
