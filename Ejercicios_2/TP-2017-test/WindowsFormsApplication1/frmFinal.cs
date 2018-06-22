using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApplication1
{
    public partial class frmFinal : Form
    {
        private MGeneral medicoGeneral;
        private MEspecialista medicoEspecialista;
        private Thread mocker;
        private Queue<Paciente> pacienteEnEspera;

        public frmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this.medicoGeneral.AtencionFinalizada += FinAtencion;
            this.medicoEspecialista.AtencionFinalizada += FinAtencion;
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            this.pacienteEnEspera = new Queue<Paciente>();
            this.mocker = new Thread(MockPacientes);
            this.mocker.Start();         
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mocker.Abort();           
        }

        private void AtenderPaciente(IMedico iMedico)
        {
            if (this.pacienteEnEspera.Count > 0) 
            {
                Paciente paciente = this.pacienteEnEspera.Dequeue();                
                iMedico.IniciarAtencion(paciente);
            }
        }

        private void FinAtencion(Paciente paciente, Medico medico)
        {
            MessageBox.Show(string.Format("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString()));
        }        

        private void MockPacientes()
        {
            int nombreNumero = 0;
            while (true)
            {
                nombreNumero++;
                this.pacienteEnEspera.Enqueue(new Paciente("tito"+nombreNumero, "fernandez"));
                Thread.Sleep(5000);             
            }
            
        }

        private void btnMGeneral_Click(object sender, EventArgs e)
        {
            this.AtenderPaciente((IMedico) this.medicoGeneral);
        }

        private void btnMEspecialista_Click(object sender, EventArgs e)
        {
            this.AtenderPaciente((IMedico)this.medicoEspecialista);
        }
    }
}
