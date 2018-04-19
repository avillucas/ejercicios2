using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Cliente
    {

        private string nombre;
        private int numero;
        public string Nombre
        {
            get {
                return this.nombre;
            }
            set {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            //TODO PREGUNTAR , es este le mejor metodo a fin de sanitizar con la propiedad ? o deberia ir contra el atributo directamente ? 
            this.Nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return c1.numero != c2.numero;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Equals(c2);
        }        
        
        public override bool Equals(Object obj)
        {
            Cliente c = (Cliente)obj;
            return (numero == c.numero);
        }
    }
}
