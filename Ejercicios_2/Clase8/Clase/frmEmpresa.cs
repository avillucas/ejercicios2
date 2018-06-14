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
    public partial class frmEmpresa : Form
    {
        private static Empresa empresa;
        public static Empresa Empresa
        {
            get
            {
                return empresa;
            }
            set
            {
                empresa = value;
            }
        }

        public frmEmpresa()
        {
            InitializeComponent();
        }
                
        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol;
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-AR");
            if (!float.TryParse(mtxtGanacias.Text,style,culture,out float ganancias))
            {
                MessageBox.Show("Las ganacias deben ser un numero flotante");
                return;
            }
            if (!Object.ReferenceEquals(empresa, null))
            {
                empresa.Ganancias = ganancias;
                empresa.RazonSocial = txtRazonSocial.Text;
                empresa.Direccion = txtDireccion.Text;
            }
            else
            { 
                empresa = new Empresa(txtRazonSocial.Text, txtDireccion.Text, ganancias);
            }
            frmEmpleado frm = new frmEmpleado();            
            frm.Show();
            
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            //autocompletar
            if (!Object.ReferenceEquals(empresa, null))
            {
                txtRazonSocial.Text = empresa.RazonSocial;
                txtDireccion.Text = empresa.Direccion;
                mtxtGanacias.Text = empresa.Ganancias.ToString();
            }            
        }
    }
}
