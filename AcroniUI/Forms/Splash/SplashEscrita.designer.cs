namespace acroni
{
    partial class SplashEscrita
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAcroni = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSlash = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblAcroni
            // 
            this.lblAcroni.AutoSize = true;
            this.lblAcroni.Font = new System.Drawing.Font("Qanelas ExtraBold", 28F, System.Drawing.FontStyle.Bold);
            this.lblAcroni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAcroni.Location = new System.Drawing.Point(75, 77);
            this.lblAcroni.Margin = new System.Windows.Forms.Padding(0);
            this.lblAcroni.Name = "lblAcroni";
            this.lblAcroni.Size = new System.Drawing.Size(0, 47);
            this.lblAcroni.TabIndex = 1;
            this.lblAcroni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlSlash
            // 
            this.pnlSlash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSlash.AutoSize = true;
            this.pnlSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlSlash.Location = new System.Drawing.Point(77, 75);
            this.pnlSlash.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlash.Name = "pnlSlash";
            this.pnlSlash.Size = new System.Drawing.Size(3, 49);
            this.pnlSlash.TabIndex = 2;
            // 
            // SplashEscrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(290, 206);
            this.Controls.Add(this.pnlSlash);
            this.Controls.Add(this.lblAcroni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashEscrita";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashEscrita";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(242)))), ((int)(((byte)(53)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAcroni;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlSlash;
    }
}

