using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        #region Metodos
      
        protected override void Atender()
        {
            
            Thread.Sleep(Medico.tiempoAleatorio.Next(1500, 2200));
            this.FinalizarAtencion();
        }
       
        void IMedico.IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(Atender);
            hilo.Start();

        }
        
        #endregion
        
        #region Constructores
        
        public MGeneral(string nombre, string apellido) 
            :base(nombre, apellido) 
        {
        }
        
        #endregion
    }
}
