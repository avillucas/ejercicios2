using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        private event DelegadoString onPersonaChange;

        public static void NotificarCambio(string msg) 
        {
            MessageBox.Show(msg);
        }

        public FormPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string msg;
            if (persona == null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                btnCrear.Text = "Actualizar";
                msg = String.Format("Se a creado la persona {0}", persona.Mostrar());            
            }
            else 
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                msg = String.Format("Se a modificado la persona {0}", persona.Mostrar());            
            }
            this.onPersonaChange(msg);
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.onPersonaChange += NotificarCambio;
        }
    }
}
