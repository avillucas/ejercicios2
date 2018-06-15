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
    
    public partial class frmTestDelegados : Form
    {
        private string foto;

        public event NameChanged OnNameChange;

        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.OnNameChange(txtNombre.Text);
        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            odfFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
         //TODO asignar la foto conseguida al formulario de datos
            //odfFoto.Pa
        }
    }
}
