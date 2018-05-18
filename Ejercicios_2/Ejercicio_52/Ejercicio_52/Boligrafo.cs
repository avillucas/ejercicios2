using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get 
            {
                return colorTinta;
            }
            set 
            {
                colorTinta = value;
            }
        }
        
        public float UnidadesDeEscritura 
        {
            get 
            {
                return tinta;
            }
            set 
            {
                tinta = value;
            }
        }
        #region "Constructores"
        /// <summary>
        /// Crea un nuevo Bligrafo
        /// </summary>
        /// <param name="unidades"></param>
        /// <param name="color"></param>
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;            
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Escribir reducirá la tinta en 0.3 por cada carácter escrito
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public EscrituraWrapper Escribir(string texto) {
            this.tinta -= (float)(texto.Length * 0.3);
            return new EscrituraWrapper(texto, this.Color);
        }

        /// <summary>
        ///Recargar incrementará tinta en tantas unidades como se agreguen.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        /// <summary>
        ///  retornará un texto informando que es Boligrafo color de escritura y nivel de tinta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Un Boligrafo");
            st.AppendFormat(" De color {0} le quedan {1}", this.Color, this.UnidadesDeEscritura);
            return st.ToString();
        }
        #endregion
    }
}
