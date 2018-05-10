using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Crea un Dulce de leche
        /// </summary>
        /// <param name="marca">Marca del dulce de leche</param>
        /// <param name="codigo">Codigo de barras</param>
        /// <param name="color">Color del frasco</param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color):base(codigo, marca, color)
        {
        }

        /// <summary>
        /// Retorna la cantidad de calorias
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);            
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
    }
}
