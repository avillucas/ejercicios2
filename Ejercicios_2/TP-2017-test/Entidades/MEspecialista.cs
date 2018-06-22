using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista: Medico , IMedico
    {

        public enum Especialidad 
        { 
            Traumatologo, 
            Odontologo
        }

        private Especialidad especialidad;
     
        #region Constructores

        public MEspecialista(string nombre, string apellido, Especialidad e) 
            :base(nombre, apellido)
        {
            this.especialidad = e;
        }

        #endregion

        #region Metodos

        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(5000, 10000));
            this.FinalizarAtencion();
        }
        
        void IMedico.IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }
        
        #endregion
    }
}
