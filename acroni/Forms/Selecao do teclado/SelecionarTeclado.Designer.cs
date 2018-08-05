namespace acroni.Forms.Seleção_do_teclado
{
    partial class SelecionarTeclado
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
            this.btnAbrirCompacto = new System.Windows.Forms.Button();
            this.btnAbrirTenkeyless = new System.Windows.Forms.Button();
            this.btnAbrirFullsize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirCompacto
            // 
            this.btnAbrirCompacto.Location = new System.Drawing.Point(755, 381);
            this.btnAbrirCompacto.Name = "btnAbrirCompacto";
            this.btnAbrirCompacto.Size = new System.Drawing.Size(136, 23);
            this.btnAbrirCompacto.TabIndex = 11;
            this.btnAbrirCompacto.Text = "Compacto (62 teclas)";
            this.btnAbrirCompacto.UseVisualStyleBackColor = true;
            this.btnAbrirCompacto.Click += new System.EventHandler(this.btnAbrirCompacto_Click);
            // 
            // btnAbrirTenkeyless
            // 
            this.btnAbrirTenkeyless.Location = new System.Drawing.Point(962, 381);
            this.btnAbrirTenkeyless.Name = "btnAbrirTenkeyless";
            this.btnAbrirTenkeyless.Size = new System.Drawing.Size(247, 23);
            this.btnAbrirTenkeyless.TabIndex = 11;
            this.btnAbrirTenkeyless.Text = "Sem teclado numérico - Tenkeyless (88 teclas)";
            this.btnAbrirTenkeyless.UseVisualStyleBackColor = true;
            // 
            // btnAbrirFullsize
            // 
            this.btnAbrirFullsize.Location = new System.Drawing.Point(1282, 381);
            this.btnAbrirFullsize.Name = "btnAbrirFullsize";
            this.btnAbrirFullsize.Size = new System.Drawing.Size(171, 23);
            this.btnAbrirFullsize.TabIndex = 11;
            this.btnAbrirFullsize.Text = "Completo (105 teclas)";
            this.btnAbrirFullsize.UseVisualStyleBackColor = true;
            // 
            // SelecionarTeclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnAbrirFullsize);
            this.Controls.Add(this.btnAbrirTenkeyless);
            this.Controls.Add(this.btnAbrirCompacto);
            this.Name = "SelecionarTeclado";
            this.Text = "SelecionarTeclado";
            this.Controls.SetChildIndex(this.btnAbrirCompacto, 0);
            this.Controls.SetChildIndex(this.btnAbrirTenkeyless, 0);
            this.Controls.SetChildIndex(this.btnAbrirFullsize, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCompacto;
        private System.Windows.Forms.Button btnAbrirTenkeyless;
        private System.Windows.Forms.Button btnAbrirFullsize;
    }
}