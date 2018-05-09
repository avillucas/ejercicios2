using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get {
                return CalcularInteres();        
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get 
            {
                return periodicidad;
            }
        }


        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        { 
        }

        /// <summary>
        /// TODO revisar
        /// </summary>
        /// <returns></returns>
        private float CalcularInteres() {            
            float porcentajePeriodicidad = (int)this.periodicidad/ 100f;
            float interes =(float) ( monto *  porcentajePeriodicidad);
            return interes;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            //TODO revisar esto  ya que no termino de entender cual seria el monto a poner o si la cuenta va a variar             
            float dolaresXDia = 2.5f;
            int dias = (int)(nuevoVencimiento - vencimiento).TotalDays;
            this.monto += (float) (dolaresXDia * dias);
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            string baseStr =  base.Mostrar();
            StringBuilder st = new StringBuilder();
            st.Append(baseStr);
            st.AppendFormat("\n\t -Moneda {0}", "Dolares");
            st.AppendFormat("\n\t -Periodicidad {0}", periodicidad.ToString());
            return st.ToString();
        }
        
    }
}
