namespace AcroniControls
{
    partial class ControlTeclado
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
            components = new System.ComponentModel.Container();
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Open Sans", 11F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Location = new System.Drawing.Point(14, 61);
            this.Size = new System.Drawing.Size(83, 85);
            this.Text = Compartilha.teclado;
            this.UseVisualStyleBackColor = false;
            this.Visible = true;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 42, 47);
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(41, 42, 47);
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(this, 5);
        }

        #endregion
    }
}
