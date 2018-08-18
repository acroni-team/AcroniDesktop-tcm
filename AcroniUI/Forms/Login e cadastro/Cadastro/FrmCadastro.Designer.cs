namespace acroni.Cadastro
{
    partial class FrmCadastro
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
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRepetirSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnSair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fotoCliente = new System.Windows.Forms.PictureBox();
            this.btnProcurarImagem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImaginario = new System.Windows.Forms.Button();
            this.pnlVisibilidade1 = new System.Windows.Forms.Panel();
            this.pnlVisibilidade2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(20, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 19);
            this.label16.TabIndex = 58;
            this.label16.Text = "Cadastro";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUsuario.HintText = "Usuário";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(24, 97);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(318, 44);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowDrop = true;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEmail.HintText = "Email";
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(370, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 44);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.AllowDrop = true;
            this.txtRepetirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepetirSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepetirSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepetirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRepetirSenha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRepetirSenha.HintText = "Repetir Senha";
            this.txtRepetirSenha.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRepetirSenha.isPassword = false;
            this.txtRepetirSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtRepetirSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRepetirSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtRepetirSenha.LineThickness = 3;
            this.txtRepetirSenha.Location = new System.Drawing.Point(370, 169);
            this.txtRepetirSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(318, 44);
            this.txtRepetirSenha.TabIndex = 4;
            this.txtRepetirSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepetirSenha.OnValueChanged += new System.EventHandler(this.txtRepetirSenha_OnValueChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSenha.HintText = "Senha";
            this.txtSenha.isPassword = false;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Location = new System.Drawing.Point(24, 169);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(318, 44);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.txtSenha_OnValueChanged);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblAviso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAviso.Location = new System.Drawing.Point(109, 35);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(202, 20);
            this.lblAviso.TabIndex = 63;
            this.lblAviso.Text = "Usuário ou senha inválidos";
            this.lblAviso.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.BorderRadius = 5;
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DisabledColor = System.Drawing.Color.Gray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSair.Iconimage = null;
            this.btnSair.Iconimage_right = null;
            this.btnSair.Iconimage_right_Selected = null;
            this.btnSair.Iconimage_Selected = null;
            this.btnSair.IconMarginLeft = 0;
            this.btnSair.IconMarginRight = 0;
            this.btnSair.IconRightVisible = true;
            this.btnSair.IconRightZoom = 0D;
            this.btnSair.IconVisible = true;
            this.btnSair.IconZoom = 90D;
            this.btnSair.IsTab = false;
            this.btnSair.Location = new System.Drawing.Point(351, 26);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSair.selected = false;
            this.btnSair.Size = new System.Drawing.Size(95, 42);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Textcolor = System.Drawing.Color.White;
            this.btnSair.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 5;
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = null;
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(460, 26);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(100, 42);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.BorderRadius = 5;
            this.btnVoltar.ButtonText = "Voltar";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gray;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVoltar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoltar.Iconimage = null;
            this.btnVoltar.Iconimage_right = null;
            this.btnVoltar.Iconimage_right_Selected = null;
            this.btnVoltar.Iconimage_Selected = null;
            this.btnVoltar.IconMarginLeft = 0;
            this.btnVoltar.IconMarginRight = 0;
            this.btnVoltar.IconRightVisible = true;
            this.btnVoltar.IconRightZoom = 0D;
            this.btnVoltar.IconVisible = true;
            this.btnVoltar.IconZoom = 90D;
            this.btnVoltar.IsTab = false;
            this.btnVoltar.Location = new System.Drawing.Point(574, 26);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(95, 42);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoltar.Textcolor = System.Drawing.Color.White;
            this.btnVoltar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // fotoCliente
            // 
            this.fotoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoCliente.Location = new System.Drawing.Point(716, 26);
            this.fotoCliente.Name = "fotoCliente";
            this.fotoCliente.Size = new System.Drawing.Size(100, 115);
            this.fotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCliente.TabIndex = 67;
            this.fotoCliente.TabStop = false;
            // 
            // btnProcurarImagem
            // 
            this.btnProcurarImagem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnProcurarImagem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProcurarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurarImagem.BorderRadius = 5;
            this.btnProcurarImagem.ButtonText = "Procurar imagem";
            this.btnProcurarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarImagem.DisabledColor = System.Drawing.Color.Gray;
            this.btnProcurarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProcurarImagem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProcurarImagem.Iconimage = null;
            this.btnProcurarImagem.Iconimage_right = null;
            this.btnProcurarImagem.Iconimage_right_Selected = null;
            this.btnProcurarImagem.Iconimage_Selected = null;
            this.btnProcurarImagem.IconMarginLeft = 0;
            this.btnProcurarImagem.IconMarginRight = 0;
            this.btnProcurarImagem.IconRightVisible = true;
            this.btnProcurarImagem.IconRightZoom = 0D;
            this.btnProcurarImagem.IconVisible = true;
            this.btnProcurarImagem.IconZoom = 90D;
            this.btnProcurarImagem.IsTab = false;
            this.btnProcurarImagem.Location = new System.Drawing.Point(716, 169);
            this.btnProcurarImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnProcurarImagem.Name = "btnProcurarImagem";
            this.btnProcurarImagem.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnProcurarImagem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnProcurarImagem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProcurarImagem.selected = false;
            this.btnProcurarImagem.Size = new System.Drawing.Size(100, 44);
            this.btnProcurarImagem.TabIndex = 5;
            this.btnProcurarImagem.Text = "Procurar imagem";
            this.btnProcurarImagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProcurarImagem.Textcolor = System.Drawing.Color.White;
            this.btnProcurarImagem.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarImagem.Click += new System.EventHandler(this.btnProcurarImagem_Click);
            // 
            // btnImaginario
            // 
            this.btnImaginario.Location = new System.Drawing.Point(356, 154);
            this.btnImaginario.Name = "btnImaginario";
            this.btnImaginario.Size = new System.Drawing.Size(0, 0);
            this.btnImaginario.TabIndex = 68;
            this.btnImaginario.UseVisualStyleBackColor = true;
            this.btnImaginario.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlVisibilidade1
            // 
            this.pnlVisibilidade1.AutoSize = true;
            this.pnlVisibilidade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlVisibilidade1.BackgroundImage = global::acroni.Properties.Resources.icons8_invisible_30;
            this.pnlVisibilidade1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlVisibilidade1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVisibilidade1.Location = new System.Drawing.Point(294, 173);
            this.pnlVisibilidade1.Name = "pnlVisibilidade1";
            this.pnlVisibilidade1.Size = new System.Drawing.Size(42, 34);
            this.pnlVisibilidade1.TabIndex = 69;
            this.pnlVisibilidade1.Click += new System.EventHandler(this.pnlVisibiladade1_Click);
            // 
            // pnlVisibilidade2
            // 
            this.pnlVisibilidade2.AutoSize = true;
            this.pnlVisibilidade2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlVisibilidade2.BackgroundImage = global::acroni.Properties.Resources.icons8_invisible_30;
            this.pnlVisibilidade2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlVisibilidade2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVisibilidade2.Location = new System.Drawing.Point(640, 172);
            this.pnlVisibilidade2.Name = "pnlVisibilidade2";
            this.pnlVisibilidade2.Size = new System.Drawing.Size(42, 34);
            this.pnlVisibilidade2.TabIndex = 70;
            this.pnlVisibilidade2.Click += new System.EventHandler(this.pnlVisibilidade2_Click);
            // 
            // FrmCadastro
            // 
            this.AcceptButton = this.btnImaginario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(843, 256);
            this.Controls.Add(this.pnlVisibilidade2);
            this.Controls.Add(this.pnlVisibilidade1);
            this.Controls.Add(this.btnImaginario);
            this.Controls.Add(this.btnProcurarImagem);
            this.Controls.Add(this.fotoCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.fotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepetirSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private System.Windows.Forms.Label lblAviso;
        protected Bunifu.Framework.UI.BunifuFlatButton btnSair;
        protected Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        protected Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        protected Bunifu.Framework.UI.BunifuFlatButton btnProcurarImagem;
        private System.Windows.Forms.PictureBox fotoCliente;
        private System.Windows.Forms.Button btnImaginario;
        private System.Windows.Forms.Panel pnlVisibilidade2;
        private System.Windows.Forms.Panel pnlVisibilidade1;
    }
}