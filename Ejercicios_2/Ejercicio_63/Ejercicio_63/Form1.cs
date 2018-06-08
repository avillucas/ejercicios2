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

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
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
            
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(AsignarHoraTimer);

            // Sets the timer interval to 1 seconds.
            myTimer.Interval = 1000;
            myTimer.Start();
            
        }

        private void AsignarHoraTimer(Object myObject, EventArgs myEventArgs)
        {
            AsignarHora();            
        }

        private void AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString("MM/dd/yy H:mm:ss");
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
    }
}
