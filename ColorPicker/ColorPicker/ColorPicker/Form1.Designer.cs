namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCorTotal = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFontePersonalizada = new System.Windows.Forms.Button();
            this.btnM = new btnColor();
            this.btnCedilha = new btnColor();
            this.btnL = new btnColor();
            this.btnK = new btnColor();
            this.button2 = new btnColor();
            this.btnN = new btnColor();
            this.btnH = new btnColor();
            this.btnP = new btnColor();
            this.btnO = new btnColor();
            this.btnI = new btnColor();
            this.btnU = new btnColor();
            this.btnY = new btnColor();
            this.btnB = new btnColor();
            this.btnT = new btnColor();
            this.btnG = new btnColor();
            this.btnV = new btnColor();
            this.btnF = new btnColor();
            this.btnR = new btnColor();
            this.btnC = new btnColor();
            this.btnD = new btnColor();
            this.btnE = new btnColor();
            this.btnX = new btnColor();
            this.btnS = new btnColor();
            this.btnW = new btnColor();
            this.btnZ = new btnColor();
            this.btnA = new btnColor();
            this.btnQ = new btnColor();
            this.MudarFonte = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(579, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(830, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // lblCorTotal
            // 
            this.lblCorTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCorTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorTotal.Location = new System.Drawing.Point(589, 450);
            this.lblCorTotal.Name = "lblCorTotal";
            this.lblCorTotal.Size = new System.Drawing.Size(382, 30);
            this.lblCorTotal.TabIndex = 38;
            this.lblCorTotal.Text = "Definir cor para todas as teclas";
            this.lblCorTotal.Click += new System.EventHandler(this.lblCorTotal_Click);
            // 
            // lblCor
            // 
            this.lblCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(589, 80);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(382, 30);
            this.lblCor.TabIndex = 39;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(379, 29);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 43;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(539, 426);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 21);
            this.cmbFont.TabIndex = 45;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(539, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fontes";
            // 
            // btnFontePersonalizada
            // 
            this.btnFontePersonalizada.Location = new System.Drawing.Point(705, 54);
            this.btnFontePersonalizada.Name = "btnFontePersonalizada";
            this.btnFontePersonalizada.Size = new System.Drawing.Size(115, 23);
            this.btnFontePersonalizada.TabIndex = 48;
            this.btnFontePersonalizada.Text = "Adicionar mais fontes";
            this.btnFontePersonalizada.UseVisualStyleBackColor = true;
            this.btnFontePersonalizada.Click += new System.EventHandler(this.btnFontePersonalizada_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.Transparent;
            this.btnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnM.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnM.Location = new System.Drawing.Point(311, 338);
            this.btnM.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(26, 26);
            this.btnM.TabIndex = 31;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnCedilha
            // 
            this.btnCedilha.BackColor = System.Drawing.Color.Transparent;
            this.btnCedilha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCedilha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCedilha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCedilha.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnCedilha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCedilha.Location = new System.Drawing.Point(384, 310);
            this.btnCedilha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnCedilha.Name = "btnCedilha";
            this.btnCedilha.Size = new System.Drawing.Size(26, 26);
            this.btnCedilha.TabIndex = 30;
            this.btnCedilha.Text = "Ç";
            this.btnCedilha.UseVisualStyleBackColor = false;
            this.btnCedilha.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Transparent;
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnL.Location = new System.Drawing.Point(354, 310);
            this.btnL.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(26, 26);
            this.btnL.TabIndex = 29;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.Transparent;
            this.btnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnK.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnK.Location = new System.Drawing.Point(325, 310);
            this.btnK.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(26, 26);
            this.btnK.TabIndex = 28;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(297, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 27;
            this.button2.Text = "J";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.Transparent;
            this.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnN.Location = new System.Drawing.Point(282, 338);
            this.btnN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(26, 26);
            this.btnN.TabIndex = 26;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.Transparent;
            this.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnH.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnH.Location = new System.Drawing.Point(268, 310);
            this.btnH.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(26, 26);
            this.btnH.TabIndex = 25;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnP.Location = new System.Drawing.Point(377, 282);
            this.btnP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(26, 26);
            this.btnP.TabIndex = 23;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.Transparent;
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnO.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnO.Location = new System.Drawing.Point(348, 282);
            this.btnO.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(26, 26);
            this.btnO.TabIndex = 22;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.Transparent;
            this.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnI.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnI.Location = new System.Drawing.Point(319, 282);
            this.btnI.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(26, 26);
            this.btnI.TabIndex = 21;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.Transparent;
            this.btnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnU.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnU.Location = new System.Drawing.Point(289, 282);
            this.btnU.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(26, 26);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "UU";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.Transparent;
            this.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnY.Location = new System.Drawing.Point(261, 282);
            this.btnY.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(26, 26);
            this.btnY.TabIndex = 19;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnB.Location = new System.Drawing.Point(253, 338);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(26, 26);
            this.btnB.TabIndex = 15;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.Transparent;
            this.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnT.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnT.Location = new System.Drawing.Point(232, 282);
            this.btnT.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(26, 26);
            this.btnT.TabIndex = 14;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.Transparent;
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnG.Location = new System.Drawing.Point(239, 310);
            this.btnG.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(26, 26);
            this.btnG.TabIndex = 13;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.Transparent;
            this.btnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnV.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnV.Location = new System.Drawing.Point(224, 338);
            this.btnV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(26, 26);
            this.btnV.TabIndex = 12;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.Transparent;
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnF.Location = new System.Drawing.Point(210, 310);
            this.btnF.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(26, 26);
            this.btnF.TabIndex = 11;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Transparent;
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnR.Location = new System.Drawing.Point(203, 282);
            this.btnR.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(26, 26);
            this.btnR.TabIndex = 10;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnC.Location = new System.Drawing.Point(195, 338);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(26, 26);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnD.Location = new System.Drawing.Point(181, 310);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(26, 26);
            this.btnD.TabIndex = 8;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Transparent;
            this.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnE.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnE.Location = new System.Drawing.Point(174, 282);
            this.btnE.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(26, 26);
            this.btnE.TabIndex = 7;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnX.Location = new System.Drawing.Point(167, 338);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(26, 26);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.Transparent;
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnS.Location = new System.Drawing.Point(152, 310);
            this.btnS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(26, 26);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.Transparent;
            this.btnW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnW.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnW.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnW.Location = new System.Drawing.Point(145, 282);
            this.btnW.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(26, 26);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.Transparent;
            this.btnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZ.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnZ.Location = new System.Drawing.Point(138, 338);
            this.btnZ.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(26, 26);
            this.btnZ.TabIndex = 3;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnA.Location = new System.Drawing.Point(123, 310);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(26, 26);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.Transparent;
            this.btnQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQ.Font = new System.Drawing.Font("Microsoft JhengHei", 6.8F);
            this.btnQ.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQ.Location = new System.Drawing.Point(116, 282);
            this.btnQ.Margin = new System.Windows.Forms.Padding(3, 3, 3, 29);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(26, 26);
            this.btnQ.TabIndex = 0;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnAbstractus_Click);
            // 
            // MudarFonte
            // 
            this.MudarFonte.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 562);
            this.Controls.Add(this.btnFontePersonalizada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCorTotal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnCedilha);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnColor btnQ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private btnColor btnH;
        private btnColor btnA;
        private btnColor btnZ;
        private btnColor btnW;
        private btnColor btnS;
        private btnColor btnX;
        private btnColor btnE;
        private btnColor btnD;
        private btnColor btnC;
        private btnColor btnR;
        private btnColor btnF;
        private btnColor btnV;
        private btnColor btnG;
        private btnColor btnT;
        private btnColor btnB;
        private btnColor btnY;
        private btnColor btnU;
        private btnColor btnI;
        private btnColor btnO;
        private btnColor btnP;
        private btnColor btnN;
        private btnColor button2;
        private btnColor btnK;
        private btnColor btnL;
        private btnColor btnCedilha;
        private btnColor btnM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCorTotal;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFontePersonalizada;
        private System.Windows.Forms.OpenFileDialog MudarFonte;
    }
}

