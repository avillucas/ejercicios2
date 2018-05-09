using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            float coeficiente = (float)(porcentajeInteres / 100);
            return (float)(monto * coeficiente);
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) :this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        { 
        }

        /// <summary>
        /// En el caso de los préstamos en pesos, se deberá aplicar un incremento del 0.25% al interés
        /// original por cada día de extendido el plazo y se actualizará la fecha original de vencimiento a
        /// la nueva fecha
        /// </summary>
        /// <param name="nuevoVencimiento"></param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {            
            float incrementoModificacion = 0.25f;
            int dias = (int)(nuevoVencimiento - vencimiento).TotalDays;
            this.porcentajeInteres +=  (dias* incrementoModificacion );
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            string baseStr = base.Mostrar();
            StringBuilder st = new StringBuilder();
            st.Append(baseStr);
            st.AppendFormat("\n\t -Moneda {0}", "Pesos");
            st.AppendFormat("\n\t -Porcentaje de interes {0}", porcentajeInteres.ToString());
            return st.ToString();
        }
        
    }
}
