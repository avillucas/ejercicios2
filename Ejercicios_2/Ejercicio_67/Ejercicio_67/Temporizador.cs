using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    class Temporizador
    {
        public delegate void EncargadoTiempo();
        public event EncargadoTiempo EventoTiempo;

        private Thread hilo;
        private int intervalo;        
        
        public bool Activo 
        {
            set 
            {
                //&&  this.hilo.ThreadState TODO VALIDAR QUE ESTE CORRIENDO EL HILO
                if(value && !this.Activo)
                {   
                    this.hilo.Start();
                }else if(!value && this.Activo){
                  this.hilo.Suspend();
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

        public void Corriendo(){
            Thread.Sleep(this.Intervalo);
            this.EventoTiempo +=;
        }        
    }
}
