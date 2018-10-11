namespace AcroniUI
{
    partial class Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.lblAcroni = new System.Windows.Forms.Label();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.pnlStripAjuda = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.pnlSuperior.Controls.Add(this.lblTutorial);
            this.pnlSuperior.Controls.Add(this.lblAjuda);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Controls.Add(this.btnMinimize);
            this.pnlSuperior.Controls.Add(this.lblAcroni);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1280, 40);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTutorial.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTutorial.ForeColor = System.Drawing.Color.White;
            this.lblTutorial.Location = new System.Drawing.Point(109, 11);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(69, 22);
            this.lblTutorial.TabIndex = 14;
            this.lblTutorial.Text = "Tutorial";
            this.lblTutorial.MouseEnter += new System.EventHandler(this.lblMenus_MouseOver);
            this.lblTutorial.MouseLeave += new System.EventHandler(this.lblMenus_MouseLeave);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjuda.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAjuda.ForeColor = System.Drawing.Color.White;
            this.lblAjuda.Location = new System.Drawing.Point(203, 10);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(53, 22);
            this.lblAjuda.TabIndex = 13;
            this.lblAjuda.Tag = "selected";
            this.lblAjuda.Text = "Ajuda";
            this.lblAjuda.MouseEnter += new System.EventHandler(this.lblMenus_MouseOver);
            this.lblAjuda.MouseLeave += new System.EventHandler(this.lblMenus_MouseLeave);
            this.lblAjuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlStripAjuda_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1182, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1140, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblAcroni
            // 
            this.lblAcroni.AutoSize = true;
            this.lblAcroni.Font = new System.Drawing.Font("Qanelas ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.lblAcroni.ForeColor = System.Drawing.Color.White;
            this.lblAcroni.Location = new System.Drawing.Point(9, 6);
            this.lblAcroni.Name = "lblAcroni";
            this.lblAcroni.Size = new System.Drawing.Size(78, 28);
            this.lblAcroni.TabIndex = 2;
            this.lblAcroni.Text = "Acroni";
            // 
            // timerFade
            // 
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // pnlStripAjuda
            // 
            this.pnlStripAjuda.BackColor = System.Drawing.Color.White;
            this.pnlStripAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStripAjuda.Location = new System.Drawing.Point(203, 31);
            this.pnlStripAjuda.Name = "pnlStripAjuda";
            this.pnlStripAjuda.Size = new System.Drawing.Size(149, 73);
            this.pnlStripAjuda.TabIndex = 15;
            this.pnlStripAjuda.Visible = false;
            this.pnlStripAjuda.MouseEnter += new System.EventHandler(this.pnlStripAjuda_MouseEnter);
            this.pnlStripAjuda.MouseLeave += new System.EventHandler(this.pnlStripAjuda_MouseLeave);
            this.pnlStripAjuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlStripAjuda_MouseMove);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlStripAjuda);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template";
            this.Opacity = 0D;
            this.Text = "FrmTemplate";
            this.Load += new System.EventHandler(this.Template_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label lblAcroni;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblTutorial;
        public System.Windows.Forms.Panel pnlStripAjuda;
    }
}