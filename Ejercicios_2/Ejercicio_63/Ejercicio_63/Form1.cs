using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Ejercicio_67;


namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        private Temporizador temporizador;
        
        //Thread hilo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            hilo = new Thread(AsignarHora);
            hilo.Start();
             * */
            /*
            do {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
             * */
            //El evento es un tipo gritando que asincronicamente determina si algo se usa o no  la respuesta no se espera para avanzar 
            //con el modelo sino que se plantea solo se avisa para que alguien haga algo pero no se espera respuesta para avanzar entonces esto hace que 
            // no haga falta levantar esperar a que responda 
            //Evento es un aviso a quienes quieran escuchar sin importar respuesta 
            //Metodo es proceso que espera respuesta para seguir procesando 
            /*
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(AsignarHoraTimer);                        
            myTimer.Interval = 1000;
            myTimer.Start();
            */
            temporizador = new Temporizador();            
            temporizador.EventoTiempo += AsignarHoraTimerHandler;            
            temporizador.Activo = true;
            //cuando pasen 4 segundos lo cortamos 
            temporizador.EventoTiempo += StopTimeHandler;

            
        }


        private string getHoraActual(){
            return DateTime.Now.ToString("MM/dd/yy H:mm:ss");
        }

        private int transacurrido;

        private void StopTimeHandler() 
        {
            this.transacurrido++;
            if (transacurrido == 4) 
            {                
                this.temporizador.Activo = false;        
            }
        }

        private void AsignarHoraTimerHandler()
        {  
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblHora.Text = this.getHoraActual();
                }
                );
            }
            else
            {
                this.lblHora.Text = this.getHoraActual();
            }
        }


        private void AsignarHoraTimer(Object myObject, EventArgs myEventArgs)
        {
            AsignarHora();            
        }

        private void AsignarHora()
        {
            this.lblHora.Text = this.getHoraActual();
        }

        private void Hilo(){
            do
            {            
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        AsignarHora();
                    }
                    );
                }
                else
                {
                    this.AsignarHora();
                }
                Thread.Sleep(1000);
            } while (true);         
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            temporizador.Activo = false;
        }
    }
}
