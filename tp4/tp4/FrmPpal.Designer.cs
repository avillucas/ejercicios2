namespace tp4
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbEstadosPaquetes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEnViaje = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstEntregado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.grbEstadosPaquetes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEstadosPaquetes
            // 
            this.grbEstadosPaquetes.Controls.Add(this.label3);
            this.grbEstadosPaquetes.Controls.Add(this.label2);
            this.grbEstadosPaquetes.Controls.Add(this.lstEnViaje);
            this.grbEstadosPaquetes.Controls.Add(this.label1);
            this.grbEstadosPaquetes.Controls.Add(this.lstIngresado);
            this.grbEstadosPaquetes.Controls.Add(this.lstEntregado);
            this.grbEstadosPaquetes.Location = new System.Drawing.Point(12, 21);
            this.grbEstadosPaquetes.Name = "grbEstadosPaquetes";
            this.grbEstadosPaquetes.Size = new System.Drawing.Size(740, 252);
            this.grbEstadosPaquetes.TabIndex = 5;
            this.grbEstadosPaquetes.TabStop = false;
            this.grbEstadosPaquetes.Text = "Estados Paquetes";
            this.grbEstadosPaquetes.Enter += new System.EventHandler(this.grbEstadosPaquetes_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "En Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Entregado";
            // 
            // lstEnViaje
            // 
            this.lstEnViaje.FormattingEnabled = true;
            this.lstEnViaje.Location = new System.Drawing.Point(242, 48);
            this.lstEnViaje.Name = "lstEnViaje";
            this.lstEnViaje.Size = new System.Drawing.Size(207, 173);
            this.lstEnViaje.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingresado";
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(8, 48);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(207, 173);
            this.lstIngresado.TabIndex = 11;
            // 
            // lstEntregado
            // 
            this.lstEntregado.FormattingEnabled = true;
            this.lstEntregado.Location = new System.Drawing.Point(481, 48);
            this.lstEntregado.Name = "lstEntregado";
            this.lstEntregado.Size = new System.Drawing.Size(207, 173);
            this.lstEntregado.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblTrackingID);
            this.groupBox1.Controls.Add(this.btnMostrarTodos);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(453, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquete";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(185, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(185, 99);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(108, 21);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(18, 30);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 2;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 53);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(20, 299);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(427, 139);
            this.rtbMostrar.TabIndex = 7;
            this.rtbMostrar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(158, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbEstadosPaquetes);
            this.Name = "FrmPpal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.grbEstadosPaquetes.ResumeLayout(false);
            this.grbEstadosPaquetes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbEstadosPaquetes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEnViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.ListBox lstEntregado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}

