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
            this.alblMessage1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alblMessage2 = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.apnlTextbox = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.apnlTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeclado
            // 
            this.txtTeclado.Location = new System.Drawing.Point(19, 83);
            this.txtTeclado.Name = "txtTeclado";
            this.txtTeclado.Size = new System.Drawing.Size(193, 20);
            this.txtTeclado.TabIndex = 1;
            // 
            // alblMessage1
            // 
            this.alblMessage1.AutoSize = true;
            this.alblMessage1.Font = new System.Drawing.Font("Open Sans", 18.25F, System.Drawing.FontStyle.Bold);
            this.alblMessage1.ForeColor = System.Drawing.Color.White;
            this.alblMessage1.Location = new System.Drawing.Point(220, 52);
            this.alblMessage1.Name = "alblMessage1";
            this.alblMessage1.Size = new System.Drawing.Size(240, 34);
            this.alblMessage1.TabIndex = 0;
            this.alblMessage1.Text = "Estamos quase lá.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.alblMessage2);
            this.panel1.Controls.Add(this.alblMessage1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 150);
            this.panel1.TabIndex = 1;
            // 
            // alblMessage2
            // 
            this.alblMessage2.AutoSize = true;
            this.alblMessage2.Font = new System.Drawing.Font("Open Sans", 12.5F);
            this.alblMessage2.ForeColor = System.Drawing.Color.White;
            this.alblMessage2.Location = new System.Drawing.Point(100, 86);
            this.alblMessage2.Name = "alblMessage2";
            this.alblMessage2.Size = new System.Drawing.Size(496, 23);
            this.alblMessage2.TabIndex = 0;
            this.alblMessage2.Text = "Um código foi enviado pro seu email. Agora é só colar ele aqui.";
            this.alblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.txtUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInput.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInput.Location = new System.Drawing.Point(0, 19);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(365, 22);
            this.txtUserInput.TabIndex = 2;
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apnlTextbox
            // 
            this.apnlTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.apnlTextbox.Controls.Add(this.txtUserInput);
            this.apnlTextbox.Location = new System.Drawing.Point(157, 190);
            this.apnlTextbox.Name = "apnlTextbox";
            this.apnlTextbox.Size = new System.Drawing.Size(365, 60);
            this.apnlTextbox.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnEnviar.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(393, 281);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 46);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnCancelar.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(170, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcroniMessageBoxInput
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(700, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.apnlTextbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcroniMessageBoxInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.apnlTextbox.ResumeLayout(false);
            this.apnlTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeclado;
        private System.Windows.Forms.Label alblMessage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alblMessage2;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Panel apnlTextbox;
        private System.Windows.Forms.Label btnEnviar;
        private System.Windows.Forms.Label btnCancelar;
    }
}
