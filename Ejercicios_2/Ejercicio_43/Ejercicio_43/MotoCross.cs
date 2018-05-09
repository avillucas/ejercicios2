using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        public short Cilindrada
        {
            get 
            {
                return cilindrada;
            }
            set{
                cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia): base(numero, escuderia)
        {            
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !m1.Equals(m2);
        }

        public override bool Equals(Object obj)
        {
            MotoCross m1 = (MotoCross)obj;
            return (Numero == m1.Numero && Escuderia == m1.Escuderia && Cilindrada == m1.Cilindrada);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La moto numero {0} de la escuderia {1} con cilidrada {4} le quedan {2} vueltas con {3} de combustible", this.Numero, this.Escuderia, this.VueltasRestantes, this.CantidadCombustible,this.Cilindrada);
            if (this.EnCompetencia)
            {
                sb.Append(" esta en competencia ");
            }
            else
            {
                sb.Append(" No esta en competencia ");
            }
            return sb.ToString();
        }
    }
}
