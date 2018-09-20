﻿namespace AcroniControls
{
    partial class MessageBoxSemInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxSemInternet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntendi = new System.Windows.Forms.PictureBox();
            this.lblEntendi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntendi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 275);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sem Internet!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(81, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 116);
            this.label2.TabIndex = 2;
            this.label2.Text = "A gente não conseguiu detectar nenhuma conexão com a Internet. Se já estiver cone" +
    "ctado, tente de novo. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEntendi
            // 
            this.btnEntendi.Image = ((System.Drawing.Image)(resources.GetObject("btnEntendi.Image")));
            this.btnEntendi.Location = new System.Drawing.Point(85, 432);
            this.btnEntendi.Name = "btnEntendi";
            this.btnEntendi.Size = new System.Drawing.Size(234, 62);
            this.btnEntendi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEntendi.TabIndex = 4;
            this.btnEntendi.TabStop = false;
            this.btnEntendi.Click += new System.EventHandler(this.btnEntendi_Click);
            // 
            // lblEntendi
            // 
            this.lblEntendi.AutoSize = true;
            this.lblEntendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.lblEntendi.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntendi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEntendi.Location = new System.Drawing.Point(153, 448);
            this.lblEntendi.Name = "lblEntendi";
            this.lblEntendi.Size = new System.Drawing.Size(95, 30);
            this.lblEntendi.TabIndex = 2;
            this.lblEntendi.Text = "Entendi";
            this.lblEntendi.Click += new System.EventHandler(this.lblEntendi_Click);
            // 
            // MessageBoxSemInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(413, 527);
            this.Controls.Add(this.lblEntendi);
            this.Controls.Add(this.btnEntendi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxSemInternet";
            this.Text = "MessageBoxSemInternet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntendi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnEntendi;
        private System.Windows.Forms.Label lblEntendi;
    }
}