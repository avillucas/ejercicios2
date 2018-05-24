using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpleadoLibrary;

namespace Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtLegajo.Text = "";
            mtxtGanacias.Text = "";
            cmbPuesto.Text = "";
            rtxtConsola.Text = "";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {

        }

        private void frmLoad(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }
    }
}
