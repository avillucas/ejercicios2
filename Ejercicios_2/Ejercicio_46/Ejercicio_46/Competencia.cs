using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        public TipoCompetencia tipo;
        
        public enum TipoCompetencia{
             F1,
             MotoCross
        }

        public List<VehiculoDeCarrera> Competidores
        {
            get 
            {
                return competidores;
            }            
        }

        public short CantidadDeCompetidores
        {
            get
            {
                return cantidadCompetidores;
            }
            set
            {
                cantidadCompetidores = value;
            }
        }

        public short CantidadDeVueltas
        {
            get
            {
                return cantidadVueltas;
            }
            set 
            {
                cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {                
                return competidores[i];
            }          
        }

        public TipoCompetencia Tipo
        {

            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }

        }

                
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo):this()
        {
            this.CantidadDeVueltas = cantidadVueltas;
            this.CantidadDeCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Elimina un vehiculo de la competencia
        /// </summary>
        /// <param name="c">Competencia</param>
        /// <param name="v">Vehiculo que eliminar</param>
        /// <returns></returns>
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            try
            {
                if (c != v)
                {
                    return false;
                }
            }
            catch (CompetenciaNoDisponibleException ce)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", ce);
            }
            //El vehiculo no existe en la competencia
            if (!c.competidores.Contains(v))
            {
                return false;
            }
            c.competidores.Remove(v);
            return true;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            //Si el tipo de vehiculo NO  pertenece
            try
            {
                if (c != v)
                {                    
                    return false;
                }
            }
            catch (CompetenciaNoDisponibleException ce)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", ce);
            }

            //si NO queda espacio
            if (c.competidores.Count >= c.cantidadCompetidores)
            {
                return false;
            }
            //Si el competidor no esta en la competencia
            if (c.competidores.Contains(v)) {
                return false;
            }
            //c.competidores
            v.EnCompetencia = true;
            Random combustible = new Random();
            v.CantidadCombustible = (short) combustible.Next(15,100);
            v.VueltasRestantes = c.cantidadVueltas;
            //agregarlo
            c.competidores.Add(v);
            return true;
        }

        
        /// <summary>
        /// Si el vehiculo es del tipo de la competencia
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if(c.tipo == Competencia.TipoCompetencia.MotoCross && v is MotoCross )
            {
                return true;
            }
            else if (c.tipo == Competencia.TipoCompetencia.F1 && v is AutoF1)
            {
                return true;
            }
            throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia","Competencia","==");            
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c==v);
        }
        
    }
}
