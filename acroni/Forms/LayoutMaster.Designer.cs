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
            this.btnAbrirGaleria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFaleConosco = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBaixarTeclado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnContinuarCustomizando = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAbrirSelecaoDeTeclado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.fotoUsuario = new System.Windows.Forms.PictureBox();
            this.btnDesconectar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
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
            this.ePnlEsquerdo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eFotoUsuario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.btnAbrirGaleria);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.btnFaleConosco);
            this.panel1.Controls.Add(this.btnBaixarTeclado);
            this.panel1.Controls.Add(this.btnContinuarCustomizando);
            this.panel1.Controls.Add(this.btnAbrirSelecaoDeTeclado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1301);
            this.panel1.TabIndex = 8;
            // 
            // btnAbrirGaleria
            // 
            this.btnAbrirGaleria.ActiveBorderThickness = 1;
            this.btnAbrirGaleria.ActiveCornerRadius = 20;
            this.btnAbrirGaleria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAbrirGaleria.ActiveForecolor = System.Drawing.Color.White;
            this.btnAbrirGaleria.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAbrirGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbrirGaleria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirGaleria.BackgroundImage")));
            this.btnAbrirGaleria.ButtonText = "Minha galeria";
            this.btnAbrirGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirGaleria.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnAbrirGaleria.ForeColor = System.Drawing.Color.White;
            this.btnAbrirGaleria.IdleBorderThickness = 2;
            this.btnAbrirGaleria.IdleCornerRadius = 2;
            this.btnAbrirGaleria.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbrirGaleria.IdleForecolor = System.Drawing.Color.White;
            this.btnAbrirGaleria.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAbrirGaleria.Location = new System.Drawing.Point(64, 312);
            this.btnAbrirGaleria.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirGaleria.Name = "btnAbrirGaleria";
            this.btnAbrirGaleria.Size = new System.Drawing.Size(350, 60);
            this.btnAbrirGaleria.TabIndex = 8;
            this.btnAbrirGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Quem somos";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 2;
            this.bunifuThinButton24.IdleCornerRadius = 2;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.Location = new System.Drawing.Point(64, 712);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(350, 60);
            this.bunifuThinButton24.TabIndex = 9;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFaleConosco
            // 
            this.btnFaleConosco.ActiveBorderThickness = 1;
            this.btnFaleConosco.ActiveCornerRadius = 20;
            this.btnFaleConosco.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnFaleConosco.ActiveForecolor = System.Drawing.Color.White;
            this.btnFaleConosco.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnFaleConosco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnFaleConosco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaleConosco.BackgroundImage")));
            this.btnFaleConosco.ButtonText = "Fale conosco";
            this.btnFaleConosco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaleConosco.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnFaleConosco.ForeColor = System.Drawing.Color.White;
            this.btnFaleConosco.IdleBorderThickness = 2;
            this.btnFaleConosco.IdleCornerRadius = 2;
            this.btnFaleConosco.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnFaleConosco.IdleForecolor = System.Drawing.Color.White;
            this.btnFaleConosco.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnFaleConosco.Location = new System.Drawing.Point(64, 632);
            this.btnFaleConosco.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaleConosco.Name = "btnFaleConosco";
            this.btnFaleConosco.Size = new System.Drawing.Size(350, 60);
            this.btnFaleConosco.TabIndex = 9;
            this.btnFaleConosco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaixarTeclado
            // 
            this.btnBaixarTeclado.ActiveBorderThickness = 1;
            this.btnBaixarTeclado.ActiveCornerRadius = 20;
            this.btnBaixarTeclado.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnBaixarTeclado.ActiveForecolor = System.Drawing.Color.White;
            this.btnBaixarTeclado.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnBaixarTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnBaixarTeclado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaixarTeclado.BackgroundImage")));
            this.btnBaixarTeclado.ButtonText = "Baixar teclado";
            this.btnBaixarTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarTeclado.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnBaixarTeclado.ForeColor = System.Drawing.Color.White;
            this.btnBaixarTeclado.IdleBorderThickness = 2;
            this.btnBaixarTeclado.IdleCornerRadius = 2;
            this.btnBaixarTeclado.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnBaixarTeclado.IdleForecolor = System.Drawing.Color.White;
            this.btnBaixarTeclado.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnBaixarTeclado.Location = new System.Drawing.Point(64, 552);
            this.btnBaixarTeclado.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaixarTeclado.Name = "btnBaixarTeclado";
            this.btnBaixarTeclado.Size = new System.Drawing.Size(350, 60);
            this.btnBaixarTeclado.TabIndex = 9;
            this.btnBaixarTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuarCustomizando
            // 
            this.btnContinuarCustomizando.ActiveBorderThickness = 1;
            this.btnContinuarCustomizando.ActiveCornerRadius = 20;
            this.btnContinuarCustomizando.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnContinuarCustomizando.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnContinuarCustomizando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnContinuarCustomizando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuarCustomizando.BackgroundImage")));
            this.btnContinuarCustomizando.ButtonText = "Continuar editando";
            this.btnContinuarCustomizando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarCustomizando.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnContinuarCustomizando.ForeColor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.IdleBorderThickness = 2;
            this.btnContinuarCustomizando.IdleCornerRadius = 2;
            this.btnContinuarCustomizando.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnContinuarCustomizando.IdleForecolor = System.Drawing.Color.White;
            this.btnContinuarCustomizando.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnContinuarCustomizando.Location = new System.Drawing.Point(64, 472);
            this.btnContinuarCustomizando.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuarCustomizando.Name = "btnContinuarCustomizando";
            this.btnContinuarCustomizando.Size = new System.Drawing.Size(350, 60);
            this.btnContinuarCustomizando.TabIndex = 9;
            this.btnContinuarCustomizando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbrirSelecaoDeTeclado
            // 
            this.btnAbrirSelecaoDeTeclado.ActiveBorderThickness = 1;
            this.btnAbrirSelecaoDeTeclado.ActiveCornerRadius = 20;
            this.btnAbrirSelecaoDeTeclado.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAbrirSelecaoDeTeclado.ActiveForecolor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAbrirSelecaoDeTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbrirSelecaoDeTeclado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirSelecaoDeTeclado.BackgroundImage")));
            this.btnAbrirSelecaoDeTeclado.ButtonText = "Criar novo teclado";
            this.btnAbrirSelecaoDeTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirSelecaoDeTeclado.Font = new System.Drawing.Font("Open Sans", 15.25F);
            this.btnAbrirSelecaoDeTeclado.ForeColor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.IdleBorderThickness = 2;
            this.btnAbrirSelecaoDeTeclado.IdleCornerRadius = 2;
            this.btnAbrirSelecaoDeTeclado.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbrirSelecaoDeTeclado.IdleForecolor = System.Drawing.Color.White;
            this.btnAbrirSelecaoDeTeclado.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAbrirSelecaoDeTeclado.Location = new System.Drawing.Point(64, 392);
            this.btnAbrirSelecaoDeTeclado.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirSelecaoDeTeclado.Name = "btnAbrirSelecaoDeTeclado";
            this.btnAbrirSelecaoDeTeclado.Size = new System.Drawing.Size(350, 60);
            this.btnAbrirSelecaoDeTeclado.TabIndex = 10;
            this.btnAbrirSelecaoDeTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 255);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 221);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlUsuario.Controls.Add(this.fotoUsuario);
            this.pnlUsuario.Controls.Add(this.btnDesconectar);
            this.pnlUsuario.Controls.Add(this.lblNomeUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(3, 882);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(474, 147);
            this.pnlUsuario.TabIndex = 7;
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("fotoUsuario.Image")));
            this.fotoUsuario.Location = new System.Drawing.Point(36, 24);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(100, 100);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUsuario.TabIndex = 4;
            this.fotoUsuario.TabStop = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ActiveBorderThickness = 1;
            this.btnDesconectar.ActiveCornerRadius = 20;
            this.btnDesconectar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnDesconectar.ActiveForecolor = System.Drawing.Color.White;
            this.btnDesconectar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnDesconectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesconectar.BackgroundImage")));
            this.btnDesconectar.ButtonText = "Desconectar";
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.Font = new System.Drawing.Font("Open Sans", 12.25F);
            this.btnDesconectar.ForeColor = System.Drawing.Color.White;
            this.btnDesconectar.IdleBorderThickness = 2;
            this.btnDesconectar.IdleCornerRadius = 2;
            this.btnDesconectar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnDesconectar.IdleForecolor = System.Drawing.Color.White;
            this.btnDesconectar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnDesconectar.Location = new System.Drawing.Point(191, 73);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(190, 49);
            this.btnDesconectar.TabIndex = 9;
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Open Sans", 12.25F);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(210, 41);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(151, 23);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "Bem vindo, Vindo!";
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
            this.ePnlUsuario.TargetControl = this.pnlUsuario;
            // 
            // ePnlEsquerdo
            // 
            this.ePnlEsquerdo.ElipseRadius = 7;
            this.ePnlEsquerdo.TargetControl = this;
            // 
            // eFotoUsuario
            // 
            this.eFotoUsuario.ElipseRadius = 7;
            this.eFotoUsuario.TargetControl = this.fotoUsuario;
            // 
            // LayoutMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LayoutMaster";
            this.Text = "LayoutMaster";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuElipse eBtnFechar;
        private System.Windows.Forms.Label lblAcroni;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse eBtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse ePnlUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem faleConoscoToolStripMenuItem;
        private Panel pnlUsuario;
        private PictureBox fotoUsuario;
        private Bunifu.Framework.UI.BunifuElipse ePnlEsquerdo;
        private Bunifu.Framework.UI.BunifuElipse eFotoUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAbrirGaleria;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFaleConosco;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBaixarTeclado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinuarCustomizando;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAbrirSelecaoDeTeclado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDesconectar;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}