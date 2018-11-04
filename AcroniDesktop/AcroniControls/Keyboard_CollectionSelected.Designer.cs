using AcroniLibrary.FileInfo;

namespace AcroniControls
{
    partial class Keyboard_CollectionSelected
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxDeleteIcon = new System.Windows.Forms.PictureBox();
            this.lblKeyboardName = new System.Windows.Forms.Label();
            this.picBoxPreviewKeyboard = new System.Windows.Forms.PictureBox();
            this.lblKeyboardType = new System.Windows.Forms.Label();
            components = new System.ComponentModel.Container();
            // 
            // 
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lblKeyboardType);
            this.Controls.Add(this.lblKeyboardName);
            this.Controls.Add(this.picBoxPreviewKeyboard);
            this.Controls.Add(this.picBoxDeleteIcon);
            this.Location = new System.Drawing.Point(123, 123);
            this.Name = Share.Keyboard.ID;
            this.Size = new System.Drawing.Size(222, 222);
            this.TabIndex = 0;
            // 
            // picBoxDeleteIcon
            // 
            this.picBoxDeleteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxDeleteIcon.Image = System.Drawing.Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Images\trash.png");
            this.picBoxDeleteIcon.Location = new System.Drawing.Point(175, 13);
            this.picBoxDeleteIcon.Name = "picBoxDeleteIcon";
            this.picBoxDeleteIcon.Size = new System.Drawing.Size(29, 29);
            this.picBoxDeleteIcon.TabIndex = 22;
            this.picBoxDeleteIcon.TabStop = false;
            this.picBoxDeleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // lblKeyboardName
            // 
            this.lblKeyboardName.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyboardName.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyboardName.ForeColor = System.Drawing.Color.White;
            this.lblKeyboardName.Location = new System.Drawing.Point(0, 162);
            this.lblKeyboardName.Name = "lblKeyboardName";
            this.lblKeyboardName.Size = new System.Drawing.Size(222, 22);
            this.lblKeyboardName.TabIndex = 20;
            this.lblKeyboardName.Text = Share.Keyboard.NickName;
            this.lblKeyboardName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBoxPreviewKeyboard
            // 
            this.picBoxPreviewKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPreviewKeyboard.Location = new System.Drawing.Point(19, 70);
            this.picBoxPreviewKeyboard.Name = "picBoxPreviewKeyboard";
            this.picBoxPreviewKeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPreviewKeyboard.Size = new System.Drawing.Size(183, 61);
            this.picBoxPreviewKeyboard.Image = Share.Keyboard.KeyboardImage;
            this.picBoxPreviewKeyboard.TabIndex = 0;
            this.picBoxPreviewKeyboard.TabStop = false;
            // 
            // lblKeyboardType
            // 
            this.lblKeyboardType.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyboardType.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyboardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(103)))), ((int)(((byte)(107)))));
            this.lblKeyboardType.Location = new System.Drawing.Point(0, 185);
            this.lblKeyboardType.Name = "lblKeyboardType";
            this.lblKeyboardType.Size = new System.Drawing.Size(222, 22);
            this.lblKeyboardType.TabIndex = 21;
            this.lblKeyboardType.Text = Share.Keyboard.KeyboardType;
            this.lblKeyboardType.TextAlign = System.Drawing.ContentAlignment.TopCenter;

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxDeleteIcon;
        private System.Windows.Forms.Label lblKeyboardName;
        private System.Windows.Forms.PictureBox picBoxPreviewKeyboard;
        private System.Windows.Forms.Label lblKeyboardType;
    }
}
