using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    public sealed class Temporizador
    {
        public delegate void EncargadoTiempo();
        public event EncargadoTiempo EventoTiempo;

        private Thread hilo;
        private int intervalo;        
        
        public bool Activo 
        {
            set 
            {
                if (Object.ReferenceEquals(this.hilo, null)) 
                {
                    this.hilo = new Thread(Corriendo);
                }
                //
                if(value && !this.Activo)
                {   
                    this.hilo.Start();
                }else if(!value && this.Activo){
                    this.hilo.Abort();
                }
            }
            get 
            {
                return this.hilo.IsAlive;
            }
        }

        public int Intervalo
        {
            set
            {
                intervalo = value;
            }
            get
            {
                return intervalo;                
            }
        }

        private void Corriendo(){
            if (intervalo == 0) this.intervalo = 1000;
            do
            {
                Thread.Sleep(this.Intervalo);
                this.EventoTiempo();
            } while (true);
        }        
    }
}
