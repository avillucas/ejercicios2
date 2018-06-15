using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public delegate void NameChanged(string nombre);

    public partial class frmPrincipal : Form
    {        
       

        private frmDatos formDatos;
        private frmTestDelegados formDelegados;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            formDelegados = new frmTestDelegados();
            formDatos = new frmDatos();
            formDelegados.OnNameChange += formDatos.ActualizarNombre;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            formDelegados.Show(this);
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            formDatos.Show(this);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
