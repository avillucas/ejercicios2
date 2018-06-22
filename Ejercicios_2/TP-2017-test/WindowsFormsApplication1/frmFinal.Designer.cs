namespace WindowsFormsApplication1
{
    partial class frmFinal
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
            this.btnMGeneral = new System.Windows.Forms.Button();
            this.btnMEspecialista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMGeneral
            // 
            this.btnMGeneral.Location = new System.Drawing.Point(55, 49);
            this.btnMGeneral.Name = "btnMGeneral";
            this.btnMGeneral.Size = new System.Drawing.Size(183, 68);
            this.btnMGeneral.TabIndex = 0;
            this.btnMGeneral.Text = "Atender Medico General";
            this.btnMGeneral.UseVisualStyleBackColor = true;
            this.btnMGeneral.Click += new System.EventHandler(this.btnMGeneral_Click);
            // 
            // btnMEspecialista
            // 
            this.btnMEspecialista.Location = new System.Drawing.Point(55, 123);
            this.btnMEspecialista.Name = "btnMEspecialista";
            this.btnMEspecialista.Size = new System.Drawing.Size(183, 68);
            this.btnMEspecialista.TabIndex = 1;
            this.btnMEspecialista.Text = "Atender Medico Especialista";
            this.btnMEspecialista.UseVisualStyleBackColor = true;
            this.btnMEspecialista.Click += new System.EventHandler(this.btnMEspecialista_Click);
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMEspecialista);
            this.Controls.Add(this.btnMGeneral);
            this.Name = "frmFinal";
            this.Text = "Final 07-07-2017";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinal_FormClosing);
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMGeneral;
        private System.Windows.Forms.Button btnMEspecialista;
    }
}

