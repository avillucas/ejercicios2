using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmVista : Form
    {
        private Oficina oficina;

        public Oficina Oficina
        {
            get
            {
                return oficina;
            }
            set 
            {
                oficina = value;
            }
        }

        public frmVista()
        {
            InitializeComponent();         
        }

        /// <summary>
        /// Con el botón btnCrearOficina se instanciará una nueva Oficina con todos los datos cargados. Caso contrario
        /// dar un error con un MessageBox (sólo botón OK, ícono de error).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearOficina_Click(object sender, EventArgs e)
        {
            Departamentos dpto;
            short piso = (short) nudPiso.Value;
            Enum.TryParse<Departamentos>(cmbDepartamentoOficina.SelectedValue.ToString(), out dpto);            
            Jefe jefe = new Jefe(txtNombreJefe.Text, txtApellidoJefe.Text, txtDocumentoJefe.Text,dptFechaIngreso.Value);
            this.Oficina = new Oficina(piso, dpto, jefe);
        }

        /// <summary>
        /// Con el botón btnMostrar se mostrará en el RichTextBox rtbDatos todos los datos del oficina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)this.oficina;
        }

        /// <summary>
        ///  Para agregar empleados a una oficina se utilizará el botón btnAgregar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Object.ReferenceEquals(this.oficina, null)) 
            {
                MessageBox.Show("Debe crear una oficina");
                return;
            }
            Departamentos dpto;
            Enum.TryParse<Departamentos>(cmbDepartamento.SelectedValue.ToString(), out dpto);
            short piso = (short) nudPiso.Value;
            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, txtDocumento.Text, piso, dpto);
            this.oficina += empleado;
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamentos));
            cmbDepartamentoOficina.DataSource = Enum.GetValues(typeof(Departamentos));
        }
    }
}
