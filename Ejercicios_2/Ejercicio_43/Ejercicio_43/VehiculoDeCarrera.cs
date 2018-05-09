using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    class VehiculoDeCarrera
    {

        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombustible;
            }
            set {
                cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }
            set
            {
                enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get 
            {
                return escuderia;
            }
            set 
            {
                escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }
            set
            {
                vueltasRestantes = value;
            }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Al auto numero {0} de la escuderia {1} le quedan {2} vueltas con {3} de combustible", this.numero, this.escuderia, this.vueltasRestantes, this.cantidadCombustible);
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

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !v1.Equals(v2);
        }

        public override bool Equals(Object obj)
        {
            VehiculoDeCarrera v = (VehiculoDeCarrera)obj;
            return (numero == v.numero && escuderia == v.escuderia);
        }
    }
}
