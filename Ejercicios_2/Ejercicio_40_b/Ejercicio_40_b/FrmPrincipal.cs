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
    public partial class FrmPrincipal : Form
    {
        private static Centralita central;

        public static  Centralita Central {
            get { 
                return central; 
            }
        }

        static FrmPrincipal()
        {
            central = new Centralita("La centralita de Tito");
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamada frmLlamada =  new FrmLlamada();
            frmLlamada.ShowDialog();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            string textoAMostrar = "Total de llamada: "+Central.GanaciasPorTotal.ToString();
            FrmTotalizador frmTotalizador = new FrmTotalizador(textoAMostrar);            
            frmTotalizador.ShowDialog(); 
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            string textoAMostrar = "Total de llamadas Locales: " + Central.GananciasPorLocal.ToString();
            FrmTotalizador frmTotalizador = new FrmTotalizador(textoAMostrar);
            frmTotalizador.ShowDialog(); 
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            string textoAMostrar = "Total de llamadas Provinciales: " + Central.GanaciasPorProvincial.ToString();
            FrmTotalizador frmTotalizador = new FrmTotalizador(textoAMostrar);
            frmTotalizador.ShowDialog(); 
        }
    }
}
