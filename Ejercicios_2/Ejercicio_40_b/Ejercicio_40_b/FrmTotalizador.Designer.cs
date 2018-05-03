namespace Ejercicio_40_b
{
    partial class FrmTotalizador
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
            this.RichTxtTotalizador = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichTxtTotalizador
            // 
            this.RichTxtTotalizador.Location = new System.Drawing.Point(26, 26);
            this.RichTxtTotalizador.Name = "RichTxtTotalizador";
            this.RichTxtTotalizador.Size = new System.Drawing.Size(228, 201);
            this.RichTxtTotalizador.TabIndex = 0;
            this.RichTxtTotalizador.Text = "";
            // 
            // FrmTotalizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RichTxtTotalizador);
            this.Name = "FrmTotalizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totalizador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxtTotalizador;
    }
}