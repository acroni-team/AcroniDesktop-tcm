namespace AcroniControls
{
    partial class AcroniMessageBoxConfirm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.alblMessage2 = new System.Windows.Forms.Label();
            this.alblMessage1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.alblMessage2);
            this.panel1.Controls.Add(this.alblMessage1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 150);
            this.panel1.TabIndex = 2;
            // 
            // alblMessage2
            // 
            this.alblMessage2.Font = new System.Drawing.Font("Open Sans", 12.5F);
            this.alblMessage2.ForeColor = System.Drawing.Color.White;
            this.alblMessage2.Location = new System.Drawing.Point(0, 76);
            this.alblMessage2.Name = "alblMessage2";
            this.alblMessage2.Size = new System.Drawing.Size(640, 23);
            this.alblMessage2.TabIndex = 0;
            this.alblMessage2.Text = "Um código foi enviado pro seu email. Agora é só colar ele aqui.";
            this.alblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alblMessage1
            // 
            this.alblMessage1.Font = new System.Drawing.Font("Open Sans", 18.25F, System.Drawing.FontStyle.Bold);
            this.alblMessage1.ForeColor = System.Drawing.Color.White;
            this.alblMessage1.Location = new System.Drawing.Point(0, 42);
            this.alblMessage1.Name = "alblMessage1";
            this.alblMessage1.Size = new System.Drawing.Size(640, 34);
            this.alblMessage1.TabIndex = 0;
            this.alblMessage1.Text = "Estamos quase lá.";
            this.alblMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Open Sans", 12.5F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(338, 222);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(141, 67);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Saia agora";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Transparent;
            this.btnCancela.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Font = new System.Drawing.Font("Open Sans", 12.5F);
            this.btnCancela.ForeColor = System.Drawing.Color.White;
            this.btnCancela.Location = new System.Drawing.Point(146, 235);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(99, 41);
            this.btnCancela.TabIndex = 3;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            this.btnCancela.MouseLeave += new System.EventHandler(this.btnCancela_MouseLeave);
            this.btnCancela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancela_MouseMove);
            // 
            // AcroniMessageBoxConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcroniMessageBoxConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcroniMessageBox";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alblMessage2;
        private System.Windows.Forms.Label alblMessage1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancela;
    }
}