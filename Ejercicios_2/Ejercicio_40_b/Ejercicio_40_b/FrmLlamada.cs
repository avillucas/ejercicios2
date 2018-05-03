using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Ejercicio_40_b
{
    public partial class FrmLlamada : Form
    {
        
        public FrmLlamada()
        {
            InitializeComponent();         
        }


        private void FrmLlamada_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        
        private void btnNro1_Click(object sender, EventArgs e)
        {
            cargarNumero(1);
        }


        private void cargarNumero(short numero)
        {
            txtNumeroDestino.Text += numero.ToString();
        }

        private void btnNro2_Click(object sender, EventArgs e)
        {
            cargarNumero(2);
        }

        private void btnNro3_Click(object sender, EventArgs e)
        {
            cargarNumero(3);
        }

        private void btNro4_Click(object sender, EventArgs e)
        {
            cargarNumero(4);
        }

        private void btnNro5_Click(object sender, EventArgs e)
        {
            cargarNumero(5);
        }

        private void btnNro6_Click(object sender, EventArgs e)
        {
            cargarNumero(6);
        }

        private void btnNro7_Click(object sender, EventArgs e)
        {
            cargarNumero(7);
        }

        private void btnNro8_Click(object sender, EventArgs e)
        {
            cargarNumero(8);
        }

        private void btnNro9_Click(object sender, EventArgs e)
        {
            cargarNumero(9);
        }

        private void btnNro0_Click(object sender, EventArgs e)
        {
            cargarNumero(0);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += '*';
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += '#';
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text = "";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {            
            Llamada llamada ;
            string nroOrigen = "";
            string nroDestino = "";
            if (! GetNumeroOrigen(out nroOrigen))
            {
                MostrarMensajeCompleteOrigenError();
                return;
            }
            if (!GetNumeroDestino(out nroDestino))
            {
                MostrarMensajeCompleteDestinoError();
                return;
            }
            if (nroDestino[0] == '#')
            {
                Provincial.Franja franjaSeleccionada;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjaSeleccionada);
                llamada = new Provincial(nroOrigen, franjaSeleccionada, 5.00f, nroDestino.Substring(1));
                if (!(FrmPrincipal.Central + (Provincial)llamada))
                {
                    MostrarMensajeLlamadaInvalidaError();
                    return;
                }
            }
            else 
            {                
                llamada = new Local(nroOrigen, 5.00f, nroDestino,20f);
                if (!(FrmPrincipal.Central + (Local)llamada))
                {
                    MostrarMensajeLlamadaInvalidaError();
                    return;
                }                 
            }
            MostrarMensajeLlamando(llamada);    
        }


        private bool GetNumeroOrigen(out string numeroOrigen)
        {                        
            if(txtNroOrigen.Text.Length > 0){
                numeroOrigen =  txtNroOrigen.Text;
                return true;
            }   
            numeroOrigen ="";
            return false;
        }


        private bool GetNumeroDestino(out string numeroDestino)
        {
            if (txtNumeroDestino.Text.Length > 0)
            {
                numeroDestino = txtNumeroDestino.Text;
                return true;
            }
            numeroDestino = "";
            return false;
        }

        private void MostrarMensajeLlamadaInvalidaError() 
        {
            MessageBox.Show("El nùmero al que desea llamar es ya se encuentra entre los numeros a los que se llamó", "Error en llamada", MessageBoxButtons.OK);
        }


        private void MostrarMensajeCompleteOrigenError() 
        {
            MessageBox.Show("El numero de origen debe ser definido", "Error en llamada", MessageBoxButtons.OK);
        }

        private void MostrarMensajeCompleteDestinoError() 
        {
            MessageBox.Show("El numero de destino debe ser definido", "Error en llamada", MessageBoxButtons.OK);
        }
        
        


        private void MostrarMensajeLlamando(Llamada llamada)
        {
            MessageBox.Show(llamada.NroOrigen + ">>>" + llamada.NroDestino, "Llamando");
            //TODO analizar como hacerlo
            //int milliseconds = 2000;
            //Thread.Sleep(milliseconds);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
