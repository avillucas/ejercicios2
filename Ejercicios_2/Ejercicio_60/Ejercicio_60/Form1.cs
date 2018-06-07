using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_60
{
    public partial class Form1 : Form
    {
        private  Product producto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2012DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.adventureWorks2012DataSet.Product);

        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbProducto.SelectedValue.ToString());
            producto = ProductDAO.getOne(id);
            txtNombre.Text = this.producto.Name;
            txtId.Text = this.producto.Id.ToString();
        }

    }
}
