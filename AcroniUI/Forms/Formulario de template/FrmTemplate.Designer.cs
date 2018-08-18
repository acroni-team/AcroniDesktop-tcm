namespace acroni.Forms.Formulario_de_template
{
    partial class FrmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplate));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAcroni = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faleConoscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnSair);
            this.pnlSuperior.Controls.Add(this.lblAcroni);
            this.pnlSuperior.Controls.Add(this.menuStrip1);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1280, 50);
            this.pnlSuperior.TabIndex = 11;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.ErrorImage = null;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.InitialImage = null;
            this.btnMinimizar.Location = new System.Drawing.Point(1144, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 0;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.ErrorImage = null;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageActive = null;
            this.btnSair.InitialImage = null;
            this.btnSair.Location = new System.Drawing.Point(1189, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 30);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 11;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAcroni
            // 
            this.lblAcroni.AutoSize = true;
            this.lblAcroni.Font = new System.Drawing.Font("Open Sans ExtraBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblAcroni.ForeColor = System.Drawing.Color.White;
            this.lblAcroni.Location = new System.Drawing.Point(12, 6);
            this.lblAcroni.Name = "lblAcroni";
            this.lblAcroni.Size = new System.Drawing.Size(109, 37);
            this.lblAcroni.TabIndex = 2;
            this.lblAcroni.Text = "Acroni";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(146, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 32);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faleConoscoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 13.25F);
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // faleConoscoToolStripMenuItem
            // 
            this.faleConoscoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.faleConoscoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.faleConoscoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15);
            this.faleConoscoToolStripMenuItem.Name = "faleConoscoToolStripMenuItem";
            this.faleConoscoToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.faleConoscoToolStripMenuItem.Text = "Fale Conosco";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 13.25F);
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTemplate";
            this.Text = "FrmTemplate";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem faleConoscoToolStripMenuItem;
        protected System.Windows.Forms.Panel pnlSuperior;
        protected System.Windows.Forms.Label lblAcroni;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        protected System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    }
}