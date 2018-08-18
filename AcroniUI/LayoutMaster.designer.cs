using System.Windows.Forms;

namespace AcroniUI
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // eBtnFechar
            // 
            this.eBtnFechar.ElipseRadius = 7;
            this.eBtnFechar.TargetControl = this;
            // 
            // eBtnMinimizar
            // 
            this.eBtnMinimizar.ElipseRadius = 7;
            this.eBtnMinimizar.TargetControl = this;
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
            this.panel2.Location = new System.Drawing.Point(880, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 670);
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
            this.txtBuscarFontes.Location = new System.Drawing.Point(43, 98);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(344, 221);
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(292, 221);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(240, 221);
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
            this.cmbEstilizacaoDaFonte.Location = new System.Drawing.Point(46, 224);
            this.cmbEstilizacaoDaFonte.Name = "cmbEstilizacaoDaFonte";
            this.cmbEstilizacaoDaFonte.Size = new System.Drawing.Size(144, 21);
            this.cmbEstilizacaoDaFonte.TabIndex = 1;
            // 
            // cmbFontes
            // 
            this.cmbFontes.FormattingEnabled = true;
            this.cmbFontes.Location = new System.Drawing.Point(46, 170);
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
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fontes";
            // 
            // LayoutMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Name = "LayoutMaster";
            this.Text = "LayoutMaster";
            this.Load += new System.EventHandler(this.LayoutMaster_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pnlSuperior, 0);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse eBtnFechar;
        private Bunifu.Framework.UI.BunifuElipse eBtnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse ePnlUsuario;
        private Bunifu.Framework.UI.BunifuElipse eFotoUsuario;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private ComboBox cmbEstilizacaoDaFonte;
        private ComboBox cmbFontes;
        private Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscarFontes;
        private Panel panel2;
    }
}