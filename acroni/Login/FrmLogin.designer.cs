using static FormsDesign.FormDrag;

namespace acroni.Login
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblAviso = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.txtEntrar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            resources.ApplyResources(this.lblAviso, "lblAviso");
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblAviso.Name = "lblAviso";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label16.Name = "label16";
            // 
            // txtEntrar
            // 
            this.txtEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEntrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtEntrar, "txtEntrar");
            this.txtEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEntrar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEntrar.HintText = "Usuário";
            this.txtEntrar.isPassword = false;
            this.txtEntrar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtEntrar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEntrar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtEntrar.LineThickness = 3;
            this.txtEntrar.Name = "txtEntrar";
            this.txtEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSenha
            // 
            this.txtSenha.AllowDrop = true;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSenha.HintText = "Senha";
            this.txtSenha.isPassword = false;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.txtSenha_OnValueChanged);
            // 
            // btnSair
            // 
            this.btnSair.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.BorderRadius = 5;
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnSair.Name = "btnSair";
            this.btnSair.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSair.selected = false;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Textcolor = System.Drawing.Color.White;
            this.btnSair.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.BorderRadius = 5;
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.BorderRadius = 5;
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntrar.Iconimage = null;
            this.btnEntrar.Iconimage_right = null;
            this.btnEntrar.Iconimage_right_Selected = null;
            this.btnEntrar.Iconimage_Selected = null;
            this.btnEntrar.IconMarginLeft = 0;
            this.btnEntrar.IconMarginRight = 0;
            this.btnEntrar.IconRightVisible = true;
            this.btnEntrar.IconRightZoom = 0D;
            this.btnEntrar.IconVisible = true;
            this.btnEntrar.IconZoom = 90D;
            this.btnEntrar.IsTab = false;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnEntrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEntrar.selected = false;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Textcolor = System.Drawing.Color.White;
            this.btnEntrar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEntrar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblAviso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAviso;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEntrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        protected Bunifu.Framework.UI.BunifuFlatButton btnSair;
        protected Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        protected Bunifu.Framework.UI.BunifuFlatButton btnEntrar;
    }
}

