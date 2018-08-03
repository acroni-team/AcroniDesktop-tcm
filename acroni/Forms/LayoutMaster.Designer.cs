using System.Windows.Forms;

namespace acroni.Layout_Master
{
    partial class LayoutMaster
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
            this.eLayoutMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.btnAbrirGaleria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAbrirSelecaoDeTeclado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.fotoUsuario = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAcroni = new System.Windows.Forms.Label();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faleConoscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eBtnFechar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eBtnMinimizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ePnlUsuario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ePnlEsquerdo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eFotoUsuario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnContinuarCustomizando = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlEsquerdo.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eLayoutMaster
            // 
            this.eLayoutMaster.ElipseRadius = 5;
            this.eLayoutMaster.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlEsquerdo);
            this.panel1.Controls.Add(this.pnlUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 685);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.logo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 142);
            this.panel3.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Open Sans", 35.25F, System.Drawing.FontStyle.Bold);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(74, 40);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(179, 64);
            this.logo.TabIndex = 4;
            this.logo.Text = "Acroni";
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlEsquerdo.Controls.Add(this.btnAbrirGaleria);
            this.pnlEsquerdo.Controls.Add(this.btnContinuarCustomizando);
            this.pnlEsquerdo.Controls.Add(this.btnAbrirSelecaoDeTeclado);
            this.pnlEsquerdo.Location = new System.Drawing.Point(26, 162);
            this.pnlEsquerdo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(295, 330);
            this.pnlEsquerdo.TabIndex = 6;
            // 
            // btnAbrirGaleria
            // 
            this.btnAbrirGaleria.ActiveBorderThickness = 1;
            this.btnAbrirGaleria.ActiveCornerRadius = 20;
            this.btnAbrirGaleria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbrirGaleria.ActiveForecolor = System.Drawing.Color.White;
            this.btnAbrirGaleria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbrirGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAbrirGaleria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirGaleria.BackgroundImage")));
            this.btnAbrirGaleria.ButtonText = "Minha galeria";
            this.btnAbrirGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirGaleria.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnAbrirGaleria.ForeColor = System.Drawing.Color.White;
            this.btnAbrirGaleria.IdleBorderThickness = 2;
            this.btnAbrirGaleria.IdleCornerRadius = 2;
            this.btnAbrirGaleria.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAbrirGaleria.IdleForecolor = System.Drawing.Color.White;
            this.btnAbrirGaleria.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAbrirGaleria.Location = new System.Drawing.Point(47, 46);
            this.btnAbrirGaleria.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirGaleria.Name = "btnAbrirGaleria";
            this.btnAbrirGaleria.Size = new System.Drawing.Size(215, 60);
            this.btnAbrirGaleria.TabIndex = 2;
            this.btnAbrirGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbrirGaleria.Click += new System.EventHandler(this.btnAbrirGaleria_Click);
            // 
            // btnAbrirSelecaoDeTeclado
            // 
            this.btnAbrirSelecaoDeTeclado.ActiveBorderThickness = 1;
            this.btnAbrirSelecaoDeTeclado.ActiveCornerRadius = 20;
            this.btnAbrirSelecaoDeTeclado.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbrirSelecaoDeTeclado.ActiveForecolor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbrirSelecaoDeTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAbrirSelecaoDeTeclado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirSelecaoDeTeclado.BackgroundImage")));
            this.btnAbrirSelecaoDeTeclado.ButtonText = "Criar novo teclado";
            this.btnAbrirSelecaoDeTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirSelecaoDeTeclado.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnAbrirSelecaoDeTeclado.ForeColor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.IdleBorderThickness = 2;
            this.btnAbrirSelecaoDeTeclado.IdleCornerRadius = 2;
            this.btnAbrirSelecaoDeTeclado.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAbrirSelecaoDeTeclado.IdleForecolor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAbrirSelecaoDeTeclado.Location = new System.Drawing.Point(47, 126);
            this.btnAbrirSelecaoDeTeclado.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirSelecaoDeTeclado.Name = "btnAbrirSelecaoDeTeclado";
            this.btnAbrirSelecaoDeTeclado.Size = new System.Drawing.Size(215, 60);
            this.btnAbrirSelecaoDeTeclado.TabIndex = 2;
            this.btnAbrirSelecaoDeTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbrirSelecaoDeTeclado.Click += new System.EventHandler(this.btnAbrirSelecaoDeTeclado_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlUsuario.Controls.Add(this.bunifuThinButton21);
            this.pnlUsuario.Controls.Add(this.fotoUsuario);
            this.pnlUsuario.Controls.Add(this.lblNomeUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(26, 524);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(295, 136);
            this.pnlUsuario.TabIndex = 7;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 15;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sair";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 15;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(144, 62);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(98, 43);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("fotoUsuario.Image")));
            this.fotoUsuario.Location = new System.Drawing.Point(14, 30);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(75, 75);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUsuario.TabIndex = 4;
            this.fotoUsuario.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Open Sans", 12.25F);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(106, 30);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(174, 23);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "Bem vindo, Romário!";
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
            this.pnlSuperior.Size = new System.Drawing.Size(1299, 37);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1201, -2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 24);
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
            this.lblAcroni.Font = new System.Drawing.Font("Open Sans ExtraBold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblAcroni.ForeColor = System.Drawing.Color.White;
            this.lblAcroni.Location = new System.Drawing.Point(12, 6);
            this.lblAcroni.Name = "lblAcroni";
            this.lblAcroni.Size = new System.Drawing.Size(67, 23);
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
            this.btnFechar.Location = new System.Drawing.Point(1235, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 24);
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
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(88, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(68, 27);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faleConoscoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ajudaToolStripMenuItem_MouseMove);
            // 
            // faleConoscoToolStripMenuItem
            // 
            this.faleConoscoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.faleConoscoToolStripMenuItem.Name = "faleConoscoToolStripMenuItem";
            this.faleConoscoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.faleConoscoToolStripMenuItem.Text = "Fale Conosco";
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
            this.ePnlUsuario.TargetControl = this.pnlUsuario;
            // 
            // ePnlEsquerdo
            // 
            this.ePnlEsquerdo.ElipseRadius = 7;
            this.ePnlEsquerdo.TargetControl = this.pnlEsquerdo;
            // 
            // eFotoUsuario
            // 
            this.eFotoUsuario.ElipseRadius = 7;
            this.eFotoUsuario.TargetControl = this.fotoUsuario;
            // 
            // btnContinuarCustomizando
            // 
            this.btnContinuarCustomizando.ActiveBorderThickness = 1;
            this.btnContinuarCustomizando.ActiveCornerRadius = 20;
            this.btnContinuarCustomizando.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnContinuarCustomizando.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnContinuarCustomizando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnContinuarCustomizando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuarCustomizando.BackgroundImage")));
            this.btnContinuarCustomizando.ButtonText = "Continuar Customizando";
            this.btnContinuarCustomizando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarCustomizando.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnContinuarCustomizando.ForeColor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.IdleBorderThickness = 2;
            this.btnContinuarCustomizando.IdleCornerRadius = 2;
            this.btnContinuarCustomizando.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnContinuarCustomizando.IdleForecolor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnContinuarCustomizando.Location = new System.Drawing.Point(47, 206);
            this.btnContinuarCustomizando.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuarCustomizando.Name = "btnContinuarCustomizando";
            this.btnContinuarCustomizando.Size = new System.Drawing.Size(215, 60);
            this.btnContinuarCustomizando.TabIndex = 2;
            this.btnContinuarCustomizando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinuarCustomizando.Visible = false;
            this.btnContinuarCustomizando.Click += new System.EventHandler(this.btnContinuarCustomizando_Click);
            // 
            // LayoutMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LayoutMaster";
            this.Text = "LayoutMaster";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlEsquerdo.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse eLayoutMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label lblNomeUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAbrirSelecaoDeTeclado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAbrirGaleria;
        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuElipse eBtnFechar;
        private System.Windows.Forms.Label lblAcroni;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private Bunifu.Framework.UI.BunifuElipse eBtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse ePnlUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem faleConoscoToolStripMenuItem;
        private Panel pnlUsuario;
        private PictureBox fotoUsuario;
        private Bunifu.Framework.UI.BunifuElipse ePnlEsquerdo;
        private Bunifu.Framework.UI.BunifuElipse eFotoUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinuarCustomizando;
    }
}