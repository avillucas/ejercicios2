using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public sealed class Changuito
    {
        /// <summary>
        /// Lista de productos del changuito
        /// </summary>
        List<Producto> _productos;
        /// <summary>
        /// Espacio que queda disponible para la colocacion de productos
        /// </summary>
        int _espacioDisponible;

        /// <summary>
        /// Tipos de productos disponibles para filtrar
        /// </summary>
        public enum ETipo
        {
            Dulce, 
            Leche, 
            Snacks, 
            Todos
        }

        #region "Constructores"
        
        private Changuito()
        {
            this._productos = new List<Producto>();
        }

        /// <summary>
        /// Inicializa un changuito vacio con espaciosDisponibles espacios para llenar
        /// </summary>
        /// <param name="espacioDisponible">Espacio con el que cuenta el changuito</param>
        public Changuito(int espacioDisponible):this()
        {            
            this._espacioDisponible = espacioDisponible;
        }

        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Muestra el changuito y sus productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento , mientras sean del tipo tipoy su lista (incluidas sus herencias) 
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c._productos.Count, c._espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in c._productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Dulce:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Leche:
                        sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"

        /// <summary>
        /// Agregará un producto al changuito
        /// </summary>
        /// <param name="c">Changuito al que se le agregara el producto</param>
        /// <param name="p">Producto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            foreach (Producto v in c._productos)
            {
                if (v == p)
                    return c;
            }
            c._productos.Add(p);
            return c;
        }

        /// <summary>
        /// Quitará un producto del changuito
        /// </summary>
        /// <param name="c">Changuito del que se quitara el producto</param>
        /// <param name="p">Producto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c._productos)
            {
                if (v == p)
                {
                    break;
                }
            }
            return c;
        }

        #endregion
    }
}
