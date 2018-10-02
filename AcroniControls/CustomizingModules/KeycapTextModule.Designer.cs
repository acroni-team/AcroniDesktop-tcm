namespace AcroniControls.CustomizingModules
{
    partial class KeycapTextModule
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
            this.alblUpperText = new System.Windows.Forms.Label();
            this.alblText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apnlTextbox1 = new System.Windows.Forms.Panel();
            this.txt1 = new TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder();
            this.apnlTextbox2 = new System.Windows.Forms.Panel();
            this.txt2 = new TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder();
            this.apnlTextbox3 = new System.Windows.Forms.Panel();
            this.txt3 = new TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ebtnExit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.apnlTextbox1.SuspendLayout();
            this.apnlTextbox2.SuspendLayout();
            this.apnlTextbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // alblUpperText
            // 
            this.alblUpperText.AutoSize = true;
            this.alblUpperText.Font = new System.Drawing.Font("Open Sans", 14.75F);
            this.alblUpperText.ForeColor = System.Drawing.Color.White;
            this.alblUpperText.Location = new System.Drawing.Point(73, 23);
            this.alblUpperText.Name = "alblUpperText";
            this.alblUpperText.Size = new System.Drawing.Size(101, 27);
            this.alblUpperText.TabIndex = 0;
            this.alblUpperText.Text = "Upperkey";
            // 
            // alblText
            // 
            this.alblText.AutoSize = true;
            this.alblText.Font = new System.Drawing.Font("Open Sans", 14.75F);
            this.alblText.ForeColor = System.Drawing.Color.White;
            this.alblText.Location = new System.Drawing.Point(73, 198);
            this.alblText.Name = "alblText";
            this.alblText.Size = new System.Drawing.Size(183, 27);
            this.alblText.TabIndex = 0;
            this.alblText.Text = "Caractere do meio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bottomkey";
            // 
            // apnlTextbox1
            // 
            this.apnlTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.apnlTextbox1.Controls.Add(this.txt1);
            this.apnlTextbox1.Location = new System.Drawing.Point(73, 92);
            this.apnlTextbox1.Name = "apnlTextbox1";
            this.apnlTextbox1.Padding = new System.Windows.Forms.Padding(5);
            this.apnlTextbox1.Size = new System.Drawing.Size(328, 50);
            this.apnlTextbox1.TabIndex = 2;
            this.apnlTextbox1.Click += new System.EventHandler(this.GeneralClick);
            this.apnlTextbox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.apnlTextbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.apnlTextbox1.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.apnlTextbox1.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.apnlTextbox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.apnlTextbox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // txt1
            // 
            this.txt1.AccessibleDescription = "";
            this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txt1.Location = new System.Drawing.Point(0, 14);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(328, 21);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Um único caractere, por favor.";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.WatermarkText = "Um único caractere, por favor.";
            this.txt1.Click += new System.EventHandler(this.GeneralClick);
            this.txt1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.txt1.TextChanged += new System.EventHandler(this.GeneralTextChanged);
            this.txt1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.txt1.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.txt1.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.txt1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.txt1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // apnlTextbox2
            // 
            this.apnlTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.apnlTextbox2.Controls.Add(this.txt2);
            this.apnlTextbox2.Location = new System.Drawing.Point(78, 240);
            this.apnlTextbox2.Name = "apnlTextbox2";
            this.apnlTextbox2.Padding = new System.Windows.Forms.Padding(5);
            this.apnlTextbox2.Size = new System.Drawing.Size(328, 52);
            this.apnlTextbox2.TabIndex = 3;
            this.apnlTextbox2.Click += new System.EventHandler(this.GeneralClick);
            this.apnlTextbox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.apnlTextbox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.apnlTextbox2.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.apnlTextbox2.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.apnlTextbox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.apnlTextbox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // txt2
            // 
            this.txt2.AccessibleDescription = "";
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txt2.Location = new System.Drawing.Point(0, 14);
            this.txt2.MaxLength = 30;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(328, 21);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "Aqui pode deixar quantos quiser ;)";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.WatermarkText = "Aqui pode deixar quantos quiser ;)";
            this.txt2.Click += new System.EventHandler(this.GeneralClick);
            this.txt2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.txt2.TextChanged += new System.EventHandler(this.GeneralTextChanged);
            this.txt2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.txt2.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.txt2.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.txt2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.txt2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // apnlTextbox3
            // 
            this.apnlTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.apnlTextbox3.Controls.Add(this.txt3);
            this.apnlTextbox3.Location = new System.Drawing.Point(73, 455);
            this.apnlTextbox3.Name = "apnlTextbox3";
            this.apnlTextbox3.Padding = new System.Windows.Forms.Padding(5);
            this.apnlTextbox3.Size = new System.Drawing.Size(328, 52);
            this.apnlTextbox3.TabIndex = 3;
            this.apnlTextbox3.Click += new System.EventHandler(this.GeneralClick);
            this.apnlTextbox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.apnlTextbox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.apnlTextbox3.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.apnlTextbox3.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.apnlTextbox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.apnlTextbox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // txt3
            // 
            this.txt3.AccessibleDescription = "";
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt3.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.txt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txt3.Location = new System.Drawing.Point(0, 14);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(328, 21);
            this.txt3.TabIndex = 3;
            this.txt3.Text = "Um único caractere, por favor.";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.WatermarkText = "Um único caractere, por favor.";
            this.txt3.Click += new System.EventHandler(this.GeneralClick);
            this.txt3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseClick);
            this.txt3.TextChanged += new System.EventHandler(this.GeneralTextChanged);
            this.txt3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDown);
            this.txt3.MouseEnter += new System.EventHandler(this.GeneralEnter);
            this.txt3.MouseLeave += new System.EventHandler(this.GeneralMouseLeave);
            this.txt3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseMove);
            this.txt3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "(caractere de cima)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(73, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "(caractere da tecla de baixo)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(75, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eu particularmente acho meio estúpido exceder a quantidade \r\nde letras que uma te" +
    "cla permite. Mas você é você, não é? :D\r\n";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 12.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(151, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(190, 58);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Tira-me daqui!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ebtnExit
            // 
            this.ebtnExit.ElipseRadius = 20;
            this.ebtnExit.TargetControl = this.btnExit;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // KeycapTextModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 654);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.apnlTextbox3);
            this.Controls.Add(this.apnlTextbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alblText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alblUpperText);
            this.Controls.Add(this.apnlTextbox1);
            this.Name = "KeycapTextModule";
            this.Opacity = 0D;
            this.apnlTextbox1.ResumeLayout(false);
            this.apnlTextbox1.PerformLayout();
            this.apnlTextbox2.ResumeLayout(false);
            this.apnlTextbox2.PerformLayout();
            this.apnlTextbox3.ResumeLayout(false);
            this.apnlTextbox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alblUpperText;
        private System.Windows.Forms.Label alblText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel apnlTextbox1;
        private System.Windows.Forms.Panel apnlTextbox2;
        private System.Windows.Forms.Panel apnlTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder txt1;
        private TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder txt2;
        private TheKhanSoftsWatermarkTextbox.TextboxWithPlaceholder txt3;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuElipse ebtnExit;
        private System.Windows.Forms.TextBox textBox1;
    }
}