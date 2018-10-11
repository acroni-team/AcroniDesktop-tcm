namespace AcroniLibrary.FileInfo
{
    partial class ControlKeyboard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
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
            this.Text = Share.Keyboard.NickName;
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
