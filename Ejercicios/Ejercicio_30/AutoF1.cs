using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero">numero de coche</param>
        /// <param name="escuderia">Nombre de la escuderia</param>
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool estado)
        {
            this.enCompetencia = estado;
        }

        public void SetVueltasRestantes(short cantidad)
        {
            this.vueltasRestantes = cantidad;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Al auto numero {0} de la escuderia {1} le quedan {2} vueltas con {3} de combustible",this.numero,this.escuderia,this.vueltasRestantes,this.cantidadCombustible);
            if (this.enCompetencia)
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
            AutoF1 a = (AutoF1)obj;
            return (numero == a.numero && escuderia == a.escuderia);            
        }
    }
}
