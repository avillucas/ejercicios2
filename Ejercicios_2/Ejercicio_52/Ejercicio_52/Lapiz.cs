using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz :IAcciones
    {
        private float tamanioMina;


        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            //El set lanzará NotImplementedException.
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>        
        /// </summary>
        public float UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set
            {
                tamanioMina = value;
            }
        }

        #region "Constructores"

        /// <summary>
        /// Crea un nuevo Lapiz
        /// </summary>
        /// <param name="unidades"></param>
        public  Lapiz(int unidades) {
            this.tamanioMina = unidades;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Escribir reducirá la mina en 0.1 por cada carácter escrito.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public EscrituraWrapper Escribir(string texto)
        {
            this.tamanioMina -= (float) (texto.Length * 0.1);
            return new EscrituraWrapper(texto, this.Color);
        }

        /// <summary>
        ///Recargar lanzará NotImplementedException.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  retornará un texto informando que es Lapiz color de escritura y nivel de tinta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Un Lapiz");
            st.AppendFormat(" De color {0} le quedan {1}", this.Color, this.UnidadesDeEscritura);
            return st.ToString();
        }
        #endregion
    }
}
