namespace VistaForm
{
    partial class frmVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.lblPisoOficina = new System.Windows.Forms.Label();
            this.cmbDepartamentoOficina = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoOficina = new System.Windows.Forms.Label();
            this.lblNombreJefe = new System.Windows.Forms.Label();
            this.txtNombreJefe = new System.Windows.Forms.TextBox();
            this.lblApellidoJefe = new System.Windows.Forms.Label();
            this.txtApellidoJefe = new System.Windows.Forms.TextBox();
            this.lblDocumentoJefe = new System.Windows.Forms.Label();
            this.txtDocumentoJefe = new System.Windows.Forms.TextBox();
            this.lblFechaIngresoJefe = new System.Windows.Forms.Label();
            this.dptFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCrearOficina = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gptDatosAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.nudPisoOficina = new System.Windows.Forms.NumericUpDown();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.gpbDatosCurso.SuspendLayout();
            this.gptDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPisoOficina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.nudPisoOficina);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrearOficina);
            this.gpbDatosCurso.Controls.Add(this.dptFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblFechaIngresoJefe);
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoJefe);
            this.gpbDatosCurso.Controls.Add(this.lblDocumentoJefe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoJefe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoJefe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreJefe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreJefe);
            this.gpbDatosCurso.Controls.Add(this.lblDepartamentoOficina);
            this.gpbDatosCurso.Controls.Add(this.cmbDepartamentoOficina);
            this.gpbDatosCurso.Controls.Add(this.lblPisoOficina);
            this.gpbDatosCurso.Location = new System.Drawing.Point(40, 23);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(327, 267);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Oficina";
            // 
            // lblPisoOficina
            // 
            this.lblPisoOficina.AutoSize = true;
            this.lblPisoOficina.Location = new System.Drawing.Point(30, 45);
            this.lblPisoOficina.Name = "lblPisoOficina";
            this.lblPisoOficina.Size = new System.Drawing.Size(29, 13);
            this.lblPisoOficina.TabIndex = 0;
            this.lblPisoOficina.Text = "Pîso";
            // 
            // cmbDepartamentoOficina
            // 
            this.cmbDepartamentoOficina.FormattingEnabled = true;
            this.cmbDepartamentoOficina.Location = new System.Drawing.Point(122, 69);
            this.cmbDepartamentoOficina.Name = "cmbDepartamentoOficina";
            this.cmbDepartamentoOficina.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamentoOficina.TabIndex = 2;
            this.cmbDepartamentoOficina.Text = "A";
            // 
            // lblDepartamentoOficina
            // 
            this.lblDepartamentoOficina.AutoSize = true;
            this.lblDepartamentoOficina.Location = new System.Drawing.Point(30, 75);
            this.lblDepartamentoOficina.Name = "lblDepartamentoOficina";
            this.lblDepartamentoOficina.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamentoOficina.TabIndex = 3;
            this.lblDepartamentoOficina.Text = "Departamento";
            // 
            // lblNombreJefe
            // 
            this.lblNombreJefe.AutoSize = true;
            this.lblNombreJefe.Location = new System.Drawing.Point(30, 102);
            this.lblNombreJefe.Name = "lblNombreJefe";
            this.lblNombreJefe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreJefe.TabIndex = 4;
            this.lblNombreJefe.Text = "Nombre";
            // 
            // txtNombreJefe
            // 
            this.txtNombreJefe.Location = new System.Drawing.Point(122, 96);
            this.txtNombreJefe.Name = "txtNombreJefe";
            this.txtNombreJefe.Size = new System.Drawing.Size(187, 20);
            this.txtNombreJefe.TabIndex = 5;
            // 
            // lblApellidoJefe
            // 
            this.lblApellidoJefe.AutoSize = true;
            this.lblApellidoJefe.Location = new System.Drawing.Point(30, 125);
            this.lblApellidoJefe.Name = "lblApellidoJefe";
            this.lblApellidoJefe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoJefe.TabIndex = 6;
            this.lblApellidoJefe.Text = "Apellido";
            // 
            // txtApellidoJefe
            // 
            this.txtApellidoJefe.Location = new System.Drawing.Point(122, 122);
            this.txtApellidoJefe.Name = "txtApellidoJefe";
            this.txtApellidoJefe.Size = new System.Drawing.Size(187, 20);
            this.txtApellidoJefe.TabIndex = 7;
            // 
            // lblDocumentoJefe
            // 
            this.lblDocumentoJefe.AutoSize = true;
            this.lblDocumentoJefe.Location = new System.Drawing.Point(30, 154);
            this.lblDocumentoJefe.Name = "lblDocumentoJefe";
            this.lblDocumentoJefe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoJefe.TabIndex = 8;
            this.lblDocumentoJefe.Text = "DNI";
            // 
            // txtDocumentoJefe
            // 
            this.txtDocumentoJefe.Location = new System.Drawing.Point(122, 148);
            this.txtDocumentoJefe.Name = "txtDocumentoJefe";
            this.txtDocumentoJefe.Size = new System.Drawing.Size(187, 20);
            this.txtDocumentoJefe.TabIndex = 9;
            // 
            // lblFechaIngresoJefe
            // 
            this.lblFechaIngresoJefe.AutoSize = true;
            this.lblFechaIngresoJefe.Location = new System.Drawing.Point(29, 183);
            this.lblFechaIngresoJefe.Name = "lblFechaIngresoJefe";
            this.lblFechaIngresoJefe.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngresoJefe.TabIndex = 10;
            this.lblFechaIngresoJefe.Text = "Ingreso";
            // 
            // dptFechaIngreso
            // 
            this.dptFechaIngreso.Location = new System.Drawing.Point(121, 174);
            this.dptFechaIngreso.Name = "dptFechaIngreso";
            this.dptFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dptFechaIngreso.TabIndex = 11;
            // 
            // btnCrearOficina
            // 
            this.btnCrearOficina.Location = new System.Drawing.Point(32, 212);
            this.btnCrearOficina.Name = "btnCrearOficina";
            this.btnCrearOficina.Size = new System.Drawing.Size(128, 40);
            this.btnCrearOficina.TabIndex = 12;
            this.btnCrearOficina.Text = "Crear Oficina";
            this.btnCrearOficina.UseVisualStyleBackColor = true;
            this.btnCrearOficina.Click += new System.EventHandler(this.btnCrearOficina_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(225, 212);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 40);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gptDatosAlumno
            // 
            this.gptDatosAlumno.Controls.Add(this.nudPiso);
            this.gptDatosAlumno.Controls.Add(this.cmbDepartamento);
            this.gptDatosAlumno.Controls.Add(this.lblDepartamento);
            this.gptDatosAlumno.Controls.Add(this.btnAgregar);
            this.gptDatosAlumno.Controls.Add(this.lblPiso);
            this.gptDatosAlumno.Controls.Add(this.txtDocumento);
            this.gptDatosAlumno.Controls.Add(this.lblLegajo);
            this.gptDatosAlumno.Controls.Add(this.txtApellido);
            this.gptDatosAlumno.Controls.Add(this.lblApellido);
            this.gptDatosAlumno.Controls.Add(this.txtNombre);
            this.gptDatosAlumno.Controls.Add(this.lblNombre);
            this.gptDatosAlumno.Location = new System.Drawing.Point(408, 23);
            this.gptDatosAlumno.Name = "gptDatosAlumno";
            this.gptDatosAlumno.Size = new System.Drawing.Size(327, 267);
            this.gptDatosAlumno.TabIndex = 14;
            this.gptDatosAlumno.TabStop = false;
            this.gptDatosAlumno.Text = "Datos empleado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(198, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 40);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(117, 98);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(187, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(20, 105);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(117, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(187, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(20, 132);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 14;
            this.lblPiso.Text = "Piso";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(117, 160);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 17;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(20, 164);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 16;
            this.lblDepartamento.Text = "Departamento";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(40, 306);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(695, 192);
            this.rtbDatos.TabIndex = 15;
            this.rtbDatos.Text = "";
            // 
            // nudPisoOficina
            // 
            this.nudPisoOficina.Location = new System.Drawing.Point(122, 39);
            this.nudPisoOficina.Name = "nudPisoOficina";
            this.nudPisoOficina.Size = new System.Drawing.Size(120, 20);
            this.nudPisoOficina.TabIndex = 18;
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(117, 130);
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(120, 20);
            this.nudPiso.TabIndex = 19;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gptDatosAlumno);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "frmVista";
            this.Text = "Vista del Oficina";
            this.Load += new System.EventHandler(this.frmVista_Load);
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            this.gptDatosAlumno.ResumeLayout(false);
            this.gptDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPisoOficina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearOficina;
        private System.Windows.Forms.DateTimePicker dptFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngresoJefe;
        private System.Windows.Forms.TextBox txtDocumentoJefe;
        private System.Windows.Forms.Label lblDocumentoJefe;
        private System.Windows.Forms.TextBox txtApellidoJefe;
        private System.Windows.Forms.Label lblApellidoJefe;
        private System.Windows.Forms.TextBox txtNombreJefe;
        private System.Windows.Forms.Label lblNombreJefe;
        private System.Windows.Forms.Label lblDepartamentoOficina;
        private System.Windows.Forms.ComboBox cmbDepartamentoOficina;
        private System.Windows.Forms.Label lblPisoOficina;
        private System.Windows.Forms.GroupBox gptDatosAlumno;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.NumericUpDown nudPisoOficina;
        private System.Windows.Forms.NumericUpDown nudPiso;
    }
}

