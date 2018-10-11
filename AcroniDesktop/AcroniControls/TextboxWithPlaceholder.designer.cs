namespace TheKhanSoftsWatermarkTextbox
{
    partial class TextboxWithPlaceholder
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
            this.SuspendLayout();
            // 
            // Caixinha
            // 
            this.Size = new System.Drawing.Size(804, 20);
            this.Enter += new System.EventHandler(this.Caixinha_Enter);
            this.Leave += new System.EventHandler(this.Caixinha_Leave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
