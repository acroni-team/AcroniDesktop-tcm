using System.Windows.Forms;

namespace acroni.Layout_Master
{
    public partial class LayoutMaster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutMaster));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAcroni = new System.Windows.Forms.Label();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faleConoscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eBtnFechar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eBtnMinimizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ePnlUsuario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eFotoUsuario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarFontes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbEstilizacaoDaFonte = new System.Windows.Forms.ComboBox();
            this.cmbFontes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.lblAcroni);
            this.pnlSuperior.Controls.Add(this.btnFechar);
            this.pnlSuperior.Controls.Add(this.menuStrip1);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1920, 50);
            this.pnlSuperior.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.ErrorImage = null;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.InitialImage = null;
            this.btnMinimizar.Location = new System.Drawing.Point(1762, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(52, 37);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 0;
            this.btnMinimizar.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.bunifuImageButton2_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton2_MouseMove);
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
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.ErrorImage = null;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageActive = null;
            this.btnFechar.InitialImage = null;
            this.btnFechar.Location = new System.Drawing.Point(1812, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 37);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 11;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 0;
            this.btnFechar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
            this.btnFechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton1_MouseMove);
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
            this.menuStrip1.Size = new System.Drawing.Size(195, 32);
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
            // eBtnFechar
            // 
            this.eBtnFechar.ElipseRadius = 7;
            this.eBtnFechar.TargetControl = this.btnFechar;
            // 
            // eBtnMinimizar
            // 
            this.eBtnMinimizar.ElipseRadius = 7;
            this.eBtnMinimizar.TargetControl = this.btnMinimizar;
            // 
            // ePnlUsuario
            // 
            this.ePnlUsuario.ElipseRadius = 7;
            this.ePnlUsuario.TargetControl = this;
            // 
            // eFotoUsuario
            // 
            this.eFotoUsuario.ElipseRadius = 7;
            this.eFotoUsuario.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.txtBuscarFontes);
            this.panel2.Controls.Add(this.bunifuImageButton3);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.cmbEstilizacaoDaFonte);
            this.panel2.Controls.Add(this.cmbFontes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1440, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 1030);
            this.panel2.TabIndex = 14;
            // 
            // txtBuscarFontes
            // 
            this.txtBuscarFontes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarFontes.Font = new System.Drawing.Font("Open Sans", 10.75F);
            this.txtBuscarFontes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarFontes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarFontes.HintText = "Digite uma fonte...";
            this.txtBuscarFontes.isPassword = false;
            this.txtBuscarFontes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBuscarFontes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBuscarFontes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBuscarFontes.LineThickness = 3;
            this.txtBuscarFontes.Location = new System.Drawing.Point(32, 78);
            this.txtBuscarFontes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarFontes.Name = "txtBuscarFontes";
            this.txtBuscarFontes.Size = new System.Drawing.Size(324, 47);
            this.txtBuscarFontes.TabIndex = 3;
            this.txtBuscarFontes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarFontes.OnValueChanged += new System.EventHandler(this.txtBuscarFontes_OnValueChanged);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(333, 201);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(281, 201);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(229, 201);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // cmbEstilizacaoDaFonte
            // 
            this.cmbEstilizacaoDaFonte.FormattingEnabled = true;
            this.cmbEstilizacaoDaFonte.Items.AddRange(new object[] {
            "Itálico"});
            this.cmbEstilizacaoDaFonte.Location = new System.Drawing.Point(35, 204);
            this.cmbEstilizacaoDaFonte.Name = "cmbEstilizacaoDaFonte";
            this.cmbEstilizacaoDaFonte.Size = new System.Drawing.Size(144, 21);
            this.cmbEstilizacaoDaFonte.TabIndex = 1;
            // 
            // cmbFontes
            // 
            this.cmbFontes.FormattingEnabled = true;
            this.cmbFontes.Location = new System.Drawing.Point(35, 150);
            this.cmbFontes.Name = "cmbFontes";
            this.cmbFontes.Size = new System.Drawing.Size(317, 21);
            this.cmbFontes.TabIndex = 1;
            this.cmbFontes.SelectedIndexChanged += new System.EventHandler(this.cmbFontes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fontes";
            // 
            // LayoutMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LayoutMaster";
            this.Text = "LayoutMaster";
            this.Load += new System.EventHandler(this.LayoutMaster_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuElipse eBtnFechar;
        private System.Windows.Forms.Label lblAcroni;
        private Bunifu.Framework.UI.BunifuElipse eBtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse ePnlUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem faleConoscoToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse eFotoUsuario;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private ComboBox cmbEstilizacaoDaFonte;
        private ComboBox cmbFontes;
        private Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscarFontes;
        protected Panel panel2;
    }
}