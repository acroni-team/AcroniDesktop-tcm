namespace AcroniControls
{
    partial class AcroniMessageBoxInput
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTeclado = new System.Windows.Forms.TextBox();
            this.apnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao1.FlatAppearance.BorderSize = 0;
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao1.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnOpcao2
            // 
            this.btnOpcao2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao2.FlatAppearance.BorderSize = 0;
            this.btnOpcao2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao1.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // apnlMensagem
            // 
            this.apnlMensagem.Controls.Add(this.txtTeclado);
            this.apnlMensagem.Controls.SetChildIndex(this.alblMensagem, 0);
            this.apnlMensagem.Controls.SetChildIndex(this.txtTeclado, 0);
            // 
            // txtTeclado
            // 
            this.txtTeclado.Location = new System.Drawing.Point(19, 83);
            this.txtTeclado.Name = "txtTeclado";
            this.txtTeclado.Size = new System.Drawing.Size(193, 20);
            this.txtTeclado.TabIndex = 1;
            // 
            // AcroniMessageBoxInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Name = "AcroniMessageBoxInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.apnlMensagem.ResumeLayout(false);
            this.apnlMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeclado;
    }
}
