namespace acroni.Atualizadores
{
    partial class FrmUsuario
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRepetirSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnImaginario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
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
            this.label16.Size = new System.Drawing.Size(220, 19);
            this.label16.TabIndex = 58;
            this.label16.Text = "Atualizando o seu usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Insira logo abaixo as informações para atualizarmos sua conta";
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
            this.btnSair.Location = new System.Drawing.Point(361, 25);
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
            // btnAtualizar
            // 
            this.btnAtualizar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.BorderRadius = 5;
            this.btnAtualizar.ButtonText = "Atualizar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAtualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Iconimage = null;
            this.btnAtualizar.Iconimage_right = null;
            this.btnAtualizar.Iconimage_right_Selected = null;
            this.btnAtualizar.Iconimage_Selected = null;
            this.btnAtualizar.IconMarginLeft = 0;
            this.btnAtualizar.IconMarginRight = 0;
            this.btnAtualizar.IconRightVisible = true;
            this.btnAtualizar.IconRightZoom = 0D;
            this.btnAtualizar.IconVisible = true;
            this.btnAtualizar.IconZoom = 90D;
            this.btnAtualizar.IsTab = false;
            this.btnAtualizar.Location = new System.Drawing.Point(470, 25);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAtualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizar.selected = false;
            this.btnAtualizar.Size = new System.Drawing.Size(100, 42);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Textcolor = System.Drawing.Color.White;
            this.btnAtualizar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            this.btnVoltar.Location = new System.Drawing.Point(584, 25);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(95, 42);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoltar.Textcolor = System.Drawing.Color.White;
            this.btnVoltar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.txtRepetirSenha.Location = new System.Drawing.Point(372, 175);
            this.txtRepetirSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(318, 44);
            this.txtRepetirSenha.TabIndex = 3;
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
            this.txtSenha.Location = new System.Drawing.Point(24, 175);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(318, 44);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.txtSenha_OnValueChanged);
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
            this.txtEmail.Location = new System.Drawing.Point(24, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 44);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblAviso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAviso.Location = new System.Drawing.Point(433, 110);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(202, 20);
            this.lblAviso.TabIndex = 74;
            this.lblAviso.Text = "Usuário ou senha inválidos";
            this.lblAviso.Visible = false;
            // 
            // btnImaginario
            // 
            this.btnImaginario.Location = new System.Drawing.Point(358, 159);
            this.btnImaginario.Name = "btnImaginario";
            this.btnImaginario.Size = new System.Drawing.Size(0, 0);
            this.btnImaginario.TabIndex = 75;
            this.btnImaginario.UseVisualStyleBackColor = true;
            this.btnImaginario.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmUsuario
            // 
            this.AcceptButton = this.btnImaginario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(712, 256);
            this.Controls.Add(this.btnImaginario);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atualizar o seu Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        protected Bunifu.Framework.UI.BunifuFlatButton btnSair;
        protected Bunifu.Framework.UI.BunifuFlatButton btnAtualizar;
        protected Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepetirSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnImaginario;
    }
}