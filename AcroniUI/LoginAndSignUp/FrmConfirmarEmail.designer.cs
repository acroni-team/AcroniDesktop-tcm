namespace AcroniUI.LoginAndSignUp
{
    partial class FrmConfirmarEmail
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
            this.form_arred = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.botao_redondo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReenviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnImaginario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_arred
            // 
            this.form_arred.ElipseRadius = 10;
            this.form_arred.TargetControl = this;
            // 
            // botao_redondo
            // 
            this.botao_redondo.ElipseRadius = 10;
            this.botao_redondo.TargetControl = this.btnEnviar;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEnviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.BorderRadius = 5;
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnviar.Iconimage = null;
            this.btnEnviar.Iconimage_right = null;
            this.btnEnviar.Iconimage_right_Selected = null;
            this.btnEnviar.Iconimage_Selected = null;
            this.btnEnviar.IconMarginLeft = 0;
            this.btnEnviar.IconMarginRight = 0;
            this.btnEnviar.IconRightVisible = true;
            this.btnEnviar.IconRightZoom = 0D;
            this.btnEnviar.IconVisible = true;
            this.btnEnviar.IconZoom = 90D;
            this.btnEnviar.IsTab = false;
            this.btnEnviar.Location = new System.Drawing.Point(21, 181);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEnviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnviar.selected = false;
            this.btnEnviar.Size = new System.Drawing.Size(100, 42);
            this.btnEnviar.TabIndex = 76;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Textcolor = System.Drawing.Color.White;
            this.btnEnviar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 73;
            this.label1.Text = "Um código foi enviado para o email da sua conta. Por favor, escreva o código rece" +
    "bido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(20, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 19);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "Atualizando o seu usuário";
            // 
            // btnReenviar
            // 
            this.btnReenviar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnReenviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReenviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReenviar.BorderRadius = 5;
            this.btnReenviar.ButtonText = "Reenviar";
            this.btnReenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReenviar.DisabledColor = System.Drawing.Color.Gray;
            this.btnReenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReenviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReenviar.Iconimage = null;
            this.btnReenviar.Iconimage_right = null;
            this.btnReenviar.Iconimage_right_Selected = null;
            this.btnReenviar.Iconimage_Selected = null;
            this.btnReenviar.IconMarginLeft = 0;
            this.btnReenviar.IconMarginRight = 0;
            this.btnReenviar.IconRightVisible = true;
            this.btnReenviar.IconRightZoom = 0D;
            this.btnReenviar.IconVisible = true;
            this.btnReenviar.IconZoom = 90D;
            this.btnReenviar.IsTab = false;
            this.btnReenviar.Location = new System.Drawing.Point(140, 181);
            this.btnReenviar.Margin = new System.Windows.Forms.Padding(0);
            this.btnReenviar.Name = "btnReenviar";
            this.btnReenviar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnReenviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnReenviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReenviar.selected = false;
            this.btnReenviar.Size = new System.Drawing.Size(100, 42);
            this.btnReenviar.TabIndex = 74;
            this.btnReenviar.Text = "Reenviar";
            this.btnReenviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReenviar.Textcolor = System.Drawing.Color.White;
            this.btnReenviar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReenviar.Click += new System.EventHandler(this.btnReenviar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCodigo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCodigo.HintText = "Código";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(116)))), ((int)(((byte)(219)))));
            this.txtCodigo.LineThickness = 3;
            this.txtCodigo.Location = new System.Drawing.Point(21, 116);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 44);
            this.txtCodigo.TabIndex = 75;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnImaginario
            // 
            this.btnImaginario.Location = new System.Drawing.Point(250, 20);
            this.btnImaginario.Name = "btnImaginario";
            this.btnImaginario.Size = new System.Drawing.Size(0, 0);
            this.btnImaginario.TabIndex = 77;
            this.btnImaginario.UseVisualStyleBackColor = true;
            this.btnImaginario.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmConfirmarEmail
            // 
            this.AcceptButton = this.btnImaginario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(272, 250);
            this.Controls.Add(this.btnImaginario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnReenviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfirmarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConfirmarEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse form_arred;
        private Bunifu.Framework.UI.BunifuElipse botao_redondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        protected Bunifu.Framework.UI.BunifuFlatButton btnReenviar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        protected Bunifu.Framework.UI.BunifuFlatButton btnEnviar;
        private System.Windows.Forms.Button btnImaginario;
    }
}