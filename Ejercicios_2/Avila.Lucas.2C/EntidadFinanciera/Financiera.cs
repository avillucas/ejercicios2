using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get 
            {
                return listaDePrestamos;
            }
        }

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this() 
        {
            this.razonSocial = razonSocial;
        }

        /// <summary>
        /// Conversión explícita a string retornará una cadena que contendrá la razón social, los intereses
        /// totales ganados por préstamos otorgados, los intereses por préstamos en pesos y por préstamos
        /// en dólares y el detalle de cada préstamo ordenados por fecha (se deberá utilizar StringBuilder
        /// para armar la cadena a devolver).
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static explicit operator string(Financiera f){
           StringBuilder st = new StringBuilder();
           st.AppendFormat("\n\t -Razon Social : {0} ",  f.RazonSocial);
           // TODO COMPLETAR 
           st.AppendFormat("\n\t -Intereses totales : {0:##,00} ", f.InteresesTotales);
           // TODO COMPLETAR 
           st.AppendFormat("\n\t -Intereses Pesos : {0:##,00} ", f.InteresesEnPesos);
           // TODO COMPLETAR 
           st.AppendFormat("\n\t -Intereses interesesDolares : {0:##,00} ", f.InteresesEnDolares);
           st.AppendLine("Prestamos :  ");           
           foreach (Prestamo prestamo in f.ListaDePrestamos)
           {               
               st.AppendFormat("\n\t{0}", prestamo.Mostrar());
               st.Append("\n-----------------"); 
           }
            return st.ToString();
        }

        public static string Mostrar(Financiera finanaciera) 
        {
            return (string) finanaciera;
        }

        /// <summary>
        /// TODO revisar
        /// </summary>
        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        /// <summary>
        /// TODO revisar
        /// </summary>
        /// <param name="tipoPrestamo"></param>
        /// <returns></returns>
        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo) {
            float interesGanado = 0;
            foreach (Prestamo prestamo in listaDePrestamos)
            { 
                if(prestamo is PrestamoDolar && ( tipoPrestamo == TipoDePrestamo.Dolares || tipoPrestamo == TipoDePrestamo.Todos))
                {
                    PrestamoDolar prestamoDolar = (PrestamoDolar)prestamo;
                    interesGanado += prestamoDolar.Interes;
                }else if(prestamo is PrestamoPesos && ( tipoPrestamo == TipoDePrestamo.Pesos || tipoPrestamo == TipoDePrestamo.Todos))
                {
                    PrestamoPesos prestamoPesos = (PrestamoPesos)prestamo;
                    interesGanado += prestamoPesos.Interes;
                }
            }
            return interesGanado;
        }

        public static bool operator == (Financiera financiera, Prestamo prestamo)
        {
            foreach (Prestamo prestamoTest in financiera.listaDePrestamos)
            {
                if (prestamoTest == prestamo)
                {
                    return true;                     
                }
            }
            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo) 
        {
            if (financiera != prestamo )
            {
                financiera.listaDePrestamos.Add(prestamo);
            }            
            return financiera;
        }

    }
}
