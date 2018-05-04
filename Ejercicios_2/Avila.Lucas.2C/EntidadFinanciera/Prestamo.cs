using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto 
        {
            get 
            {
                return monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return vencimiento;
            }

            set
            {
                vencimiento = value;
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.vencimiento = vencimiento;
            this.monto = monto;
        }

        /// <summary>
        /// TODO revisar relacion 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            if (p1.vencimiento > p2.vencimiento) return 1;
            if (p1.vencimiento < p2.vencimiento) return -1;
            return 0;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("\n\t -Vencimiento : {0} ", vencimiento);
            st.AppendFormat("\n\t -Monto : {0} ", monto);
            return st.ToString();
        }
    }
}
