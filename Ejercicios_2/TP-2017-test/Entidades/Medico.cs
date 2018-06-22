using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico :Persona
    {
        public delegate void FinAtencionPaciente(Paciente paciente, Medico medico);
        public event FinAtencionPaciente AtencionFinalizada;        
        
        private Paciente pacienteActual ;
        protected static Random tiempoAleatorio;

        public Paciente AtenderA
        {
            set{
                pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA 
        {
            get 
            {
                return this.pacienteActual.ToString();
            }
        }

        #region Constructores
        
        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido) 
            : base(nombre, apellido) 
        {
        }

        #endregion

        #region Metodos
        
        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            this.AtencionFinalizada(this.pacienteActual, this);
            this.pacienteActual = null;
        }
               
        #endregion
    }
}
