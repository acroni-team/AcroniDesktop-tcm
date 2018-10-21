namespace AcroniUI.Custom.CustomModules
{
    partial class KeycapTextureModule
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
            this.btnThis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlll
            // 
            this.btnAlll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnAlll.FlatAppearance.BorderSize = 0;
            this.btnAlll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAlll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            // 
            // btnThis
            // 
            this.btnThis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnThis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThis.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThis.FlatAppearance.BorderSize = 0;
            this.btnThis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnThis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThis.Font = new System.Drawing.Font("Open Sans", 10F);
            this.btnThis.ForeColor = System.Drawing.Color.White;
            this.btnThis.Location = new System.Drawing.Point(658, 250);
            this.btnThis.Name = "btnThis";
            this.btnThis.Padding = new System.Windows.Forms.Padding(5);
            this.btnThis.Size = new System.Drawing.Size(161, 58);
            this.btnThis.TabIndex = 19;
            this.btnThis.Text = "Quero essa textura só nessa tecla.";
            this.btnThis.UseVisualStyleBackColor = false;
            // 
            // KeycapTextureModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.btnThis);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "KeycapTextureModule";
            this.Text = "KeycapTextureModule";
            this.Controls.SetChildIndex(this.btnAlll, 0);
            this.Controls.SetChildIndex(this.btnThis, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThis;
    }
}