namespace AcroniControls
{
    partial class AcroniMessageBox
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
            this.btnOpcao1 = new System.Windows.Forms.Button();
            this.btnOpcao2 = new System.Windows.Forms.Button();
            this.apnlMensagem = new System.Windows.Forms.Panel();
            this.alblMensagem = new System.Windows.Forms.Label();
            this.apnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcao1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao1.FlatAppearance.BorderSize = 0;
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao1.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnOpcao1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOpcao1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpcao1.Location = new System.Drawing.Point(23, 132);
            this.btnOpcao1.Name = "btnOpcao1";
            this.btnOpcao1.Size = new System.Drawing.Size(111, 38);
            this.btnOpcao1.TabIndex = 3;
            this.btnOpcao1.TabStop = false;
            this.btnOpcao1.Text = "Sim!";
            this.btnOpcao1.UseVisualStyleBackColor = true;
            // 
            // btnOpcao2
            // 
            this.btnOpcao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcao2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOpcao2.FlatAppearance.BorderSize = 0;
            this.btnOpcao2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpcao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao2.Font = new System.Drawing.Font("Open Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnOpcao2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOpcao2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpcao2.Location = new System.Drawing.Point(153, 132);
            this.btnOpcao2.Name = "btnOpcao2";
            this.btnOpcao2.Size = new System.Drawing.Size(108, 38);
            this.btnOpcao2.TabIndex = 4;
            this.btnOpcao2.TabStop = false;
            this.btnOpcao2.Text = "Nop!";
            this.btnOpcao2.UseVisualStyleBackColor = true;
            // 
            // apnlMensagem
            // 
            this.apnlMensagem.Controls.Add(this.alblMensagem);
            this.apnlMensagem.Location = new System.Drawing.Point(23, 12);
            this.apnlMensagem.Name = "apnlMensagem";
            this.apnlMensagem.Size = new System.Drawing.Size(238, 103);
            this.apnlMensagem.TabIndex = 5;
            // 
            // alblMensagem
            // 
            this.alblMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.alblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.alblMensagem.Location = new System.Drawing.Point(0, 0);
            this.alblMensagem.Name = "alblMensagem";
            this.alblMensagem.Size = new System.Drawing.Size(238, 103);
            this.alblMensagem.TabIndex = 0;
            this.alblMensagem.Text = "Seu Texto Aqui";
            this.alblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcroniMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.apnlMensagem);
            this.Controls.Add(this.btnOpcao2);
            this.Controls.Add(this.btnOpcao1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcroniMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AcroniMessageBox";
            this.apnlMensagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnOpcao1;
        protected System.Windows.Forms.Button btnOpcao2;
        protected System.Windows.Forms.Panel apnlMensagem;
        protected System.Windows.Forms.Label alblMensagem;
    }
}