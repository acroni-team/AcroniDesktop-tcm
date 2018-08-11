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
            this.txtEntrar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lnklblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.btnImaginario = new System.Windows.Forms.Button();
            this.apnlEsquerdo = new System.Windows.Forms.Panel();
            this.alblAGenteTemOQueVocePrecisa = new System.Windows.Forms.Label();
            this.alblProcurandoPorTeclados = new System.Windows.Forms.Label();
            this.alblAcroni = new System.Windows.Forms.Label();
            this.alblEntrar = new System.Windows.Forms.Label();
            this.alblSejaBemVindo = new System.Windows.Forms.Label();
            this.apnlUsuario = new System.Windows.Forms.Panel();
            this.apnlSenha = new System.Windows.Forms.Panel();
            this.pnlVisibiladade = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.LinkLabel();
            this.alblAindaNaoTemUmaConta = new System.Windows.Forms.Label();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.eForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eBtnMinimizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.eBtnSair = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlQueDesce = new System.Windows.Forms.Panel();
            this.apnlEsquerdo.SuspendLayout();
            this.apnlUsuario.SuspendLayout();
            this.apnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.pnlQueDesce.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            resources.ApplyResources(this.lblAviso, "lblAviso");
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblAviso.Name = "lblAviso";
            // 
            // txtEntrar
            // 
            this.txtEntrar.AllowDrop = true;
            this.txtEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtEntrar, "txtEntrar");
            this.txtEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtEntrar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtEntrar.HintText = "Usuário";
            this.txtEntrar.isPassword = false;
            this.txtEntrar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntrar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntrar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEntrar.LineThickness = 3;
            this.txtEntrar.Name = "txtEntrar";
            this.txtEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEntrar.OnValueChanged += new System.EventHandler(this.txtBoxesLogin_OnValueChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtSenha.HintText = "Senha";
            this.txtSenha.isPassword = false;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.txtBoxesLogin_OnValueChanged);
            // 
            // lnklblEsqueceuSenha
            // 
            this.lnklblEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lnklblEsqueceuSenha, "lnklblEsqueceuSenha");
            this.lnklblEsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnklblEsqueceuSenha.Name = "lnklblEsqueceuSenha";
            this.lnklblEsqueceuSenha.TabStop = true;
            this.lnklblEsqueceuSenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.lnklblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblEsqueceuSenha_LinkClicked);
            // 
            // btnImaginario
            // 
            resources.ApplyResources(this.btnImaginario, "btnImaginario");
            this.btnImaginario.Name = "btnImaginario";
            this.btnImaginario.UseVisualStyleBackColor = true;
            // 
            // apnlEsquerdo
            // 
            this.apnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apnlEsquerdo.Controls.Add(this.alblAGenteTemOQueVocePrecisa);
            this.apnlEsquerdo.Controls.Add(this.alblProcurandoPorTeclados);
            this.apnlEsquerdo.Controls.Add(this.alblAcroni);
            resources.ApplyResources(this.apnlEsquerdo, "apnlEsquerdo");
            this.apnlEsquerdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apnlEsquerdo.Name = "apnlEsquerdo";
            // 
            // alblAGenteTemOQueVocePrecisa
            // 
            resources.ApplyResources(this.alblAGenteTemOQueVocePrecisa, "alblAGenteTemOQueVocePrecisa");
            this.alblAGenteTemOQueVocePrecisa.ForeColor = System.Drawing.Color.White;
            this.alblAGenteTemOQueVocePrecisa.Name = "alblAGenteTemOQueVocePrecisa";
            // 
            // alblProcurandoPorTeclados
            // 
            resources.ApplyResources(this.alblProcurandoPorTeclados, "alblProcurandoPorTeclados");
            this.alblProcurandoPorTeclados.ForeColor = System.Drawing.Color.White;
            this.alblProcurandoPorTeclados.Name = "alblProcurandoPorTeclados";
            // 
            // alblAcroni
            // 
            resources.ApplyResources(this.alblAcroni, "alblAcroni");
            this.alblAcroni.ForeColor = System.Drawing.Color.White;
            this.alblAcroni.Name = "alblAcroni";
            // 
            // alblEntrar
            // 
            resources.ApplyResources(this.alblEntrar, "alblEntrar");
            this.alblEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alblEntrar.Name = "alblEntrar";
            // 
            // alblSejaBemVindo
            // 
            resources.ApplyResources(this.alblSejaBemVindo, "alblSejaBemVindo");
            this.alblSejaBemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alblSejaBemVindo.Name = "alblSejaBemVindo";
            // 
            // apnlUsuario
            // 
            this.apnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.apnlUsuario.Controls.Add(this.txtEntrar);
            resources.ApplyResources(this.apnlUsuario, "apnlUsuario");
            this.apnlUsuario.Name = "apnlUsuario";
            // 
            // apnlSenha
            // 
            this.apnlSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.apnlSenha.Controls.Add(this.pnlVisibiladade);
            this.apnlSenha.Controls.Add(this.txtSenha);
            this.apnlSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            resources.ApplyResources(this.apnlSenha, "apnlSenha");
            this.apnlSenha.Name = "apnlSenha";
            // 
            // pnlVisibiladade
            // 
            resources.ApplyResources(this.pnlVisibiladade, "pnlVisibiladade");
            this.pnlVisibiladade.BackColor = System.Drawing.Color.Transparent;
            this.pnlVisibiladade.BackgroundImage = global::acroni.Properties.Resources.icons8_invisible_30;
            this.pnlVisibiladade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVisibiladade.Name = "pnlVisibiladade";
            this.pnlVisibiladade.Click += new System.EventHandler(this.pnlVisibiladade_Click);
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.TabStop = false;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblCadastrar, "lblCadastrar");
            this.lblCadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.TabStop = true;
            this.lblCadastrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.lblCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblEsqueceuSenha_LinkClicked);
            // 
            // alblAindaNaoTemUmaConta
            // 
            resources.ApplyResources(this.alblAindaNaoTemUmaConta, "alblAindaNaoTemUmaConta");
            this.alblAindaNaoTemUmaConta.Name = "alblAindaNaoTemUmaConta";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ImageActive = null;
            this.btnSair.Name = "btnSair";
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            this.btnSair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSair_MouseMove);
            // 
            // eForm
            // 
            this.eForm.ElipseRadius = 5;
            this.eForm.TargetControl = this;
            // 
            // eBtnMinimizar
            // 
            this.eBtnMinimizar.ElipseRadius = 5;
            this.eBtnMinimizar.TargetControl = this.btnMinimizar;
            // 
            // eBtnSair
            // 
            this.eBtnSair.ElipseRadius = 5;
            this.eBtnSair.TargetControl = this.btnSair;
            // 
            // pnlQueDesce
            // 
            resources.ApplyResources(this.pnlQueDesce, "pnlQueDesce");
            this.pnlQueDesce.Controls.Add(this.btnEntrar);
            this.pnlQueDesce.Controls.Add(this.alblAindaNaoTemUmaConta);
            this.pnlQueDesce.Controls.Add(this.lblCadastrar);
            this.pnlQueDesce.Name = "pnlQueDesce";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.pnlQueDesce);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.apnlSenha);
            this.Controls.Add(this.apnlUsuario);
            this.Controls.Add(this.alblSejaBemVindo);
            this.Controls.Add(this.alblEntrar);
            this.Controls.Add(this.apnlEsquerdo);
            this.Controls.Add(this.btnImaginario);
            this.Controls.Add(this.lnklblEsqueceuSenha);
            this.Controls.Add(this.lblAviso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.apnlEsquerdo.ResumeLayout(false);
            this.apnlEsquerdo.PerformLayout();
            this.apnlUsuario.ResumeLayout(false);
            this.apnlSenha.ResumeLayout(false);
            this.apnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.pnlQueDesce.ResumeLayout(false);
            this.pnlQueDesce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAviso;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private System.Windows.Forms.LinkLabel lnklblEsqueceuSenha;
        private System.Windows.Forms.Button btnImaginario;
        private System.Windows.Forms.Panel pnlVisibiladade;
        private System.Windows.Forms.Panel apnlUsuario;
        private System.Windows.Forms.Label alblSejaBemVindo;
        private System.Windows.Forms.Label alblEntrar;
        private System.Windows.Forms.Panel apnlEsquerdo;
        private System.Windows.Forms.Panel apnlSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEntrar;
        private System.Windows.Forms.Label alblAindaNaoTemUmaConta;
        private System.Windows.Forms.LinkLabel lblCadastrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private Bunifu.Framework.UI.BunifuElipse eForm;
        private Bunifu.Framework.UI.BunifuElipse eBtnMinimizar;
        private Bunifu.Framework.UI.BunifuElipse eBtnSair;
        protected System.Windows.Forms.Label alblAcroni;
        protected System.Windows.Forms.Label alblAGenteTemOQueVocePrecisa;
        protected System.Windows.Forms.Label alblProcurandoPorTeclados;
        private System.Windows.Forms.Panel pnlQueDesce;
        private System.Windows.Forms.Button btnEntrar;
    }
}

