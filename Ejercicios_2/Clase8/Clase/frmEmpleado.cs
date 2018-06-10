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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtLegajo.Text = "";
            mtxtSalario.Text = "";
            cmbPuesto.Text = "";
            rtxtConsola.Text = "";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol;
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-AR");

            if (!int.TryParse(mtxtSalario.Text, style, culture, out int salario))
            {
                MessageBox.Show("El salario debe ser un numero");
            }            
            Enum.TryParse<EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out EPuestoJerarquico  puesto);
            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, salario);
            frmEmpresa.Empresa += empleado;
            rtxtConsola.Text = frmEmpresa.Empresa.MostrarEmpresa();
        }

        private void frmLoad(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
            cmbPuesto.Text = EPuestoJerarquico.Sistemas.ToString();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
