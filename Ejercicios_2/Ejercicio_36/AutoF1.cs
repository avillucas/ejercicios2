using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class AutoF1 : VehiculoDeCarrera
    {
  

        private short caballosDeFuerza;

        public short CaballosDeFuerza 
        {
            get
            {
                return caballosDeFuerza;
            }
            set
            {
                caballosDeFuerza = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero">numero de coche</param>
        /// <param name="escuderia">Nombre de la escuderia</param>
        public AutoF1(short numero, string escuderia):base(numero,escuderia)
        {
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
        }

        
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Al auto numero {0} de la escuderia {1} le quedan {2} vueltas con {3} de combustible",this.Numero,this.Escuderia,this.VueltasRestantes,this.CantidadCombustible);
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

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Equals(a2);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !a1.Equals(a2);
        }

        public override bool Equals(Object obj)
        {
            AutoF1 a2 = (AutoF1)obj;
            return (Numero == a2.Numero && Escuderia == a2.Escuderia && CaballosDeFuerza == a2.CaballosDeFuerza);            
        }
    }
}
