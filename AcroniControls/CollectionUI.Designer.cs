using AcroniLibrary.FileInfo;

namespace AcroniControls
{
    partial class CollectionUI
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
            this.lblColecao1NumTeclados = new System.Windows.Forms.Label();
            this.lblColecao1 = new System.Windows.Forms.Label();
            this.colecao1 = new System.Windows.Forms.Panel();
            this.btnExcluirGaleria = new System.Windows.Forms.PictureBox();
            this.btnEditarGaleria = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            ///
            /// btnEditarGaleria
            ///
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarGaleria)).EndInit();
            this.btnEditarGaleria.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarGaleria.Image = Share.ResourcesImage[0];
            this.btnEditarGaleria.Location = new System.Drawing.Point(823, 12);
            this.btnEditarGaleria.Name = "btnEditarGaleria";
            this.btnEditarGaleria.Size = new System.Drawing.Size(29, 29);
            this.btnEditarGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarGaleria.TabStop = false;
            this.btnEditarGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnExcluirGaleria
            // 
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluirGaleria)).EndInit();
            this.btnExcluirGaleria.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirGaleria.Image = Share.ResourcesImage[1];
            this.btnExcluirGaleria.Location = new System.Drawing.Point(869, 14);
            this.btnExcluirGaleria.Name = "btnExcluirGaleria";
            this.btnExcluirGaleria.Size = new System.Drawing.Size(27, 27);
            this.btnExcluirGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluirGaleria.TabStop = false;
            this.btnExcluirGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // lblColecao1
            // 
            this.lblColecao1.AutoSize = true;
            this.lblColecao1.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecao1.ForeColor = System.Drawing.Color.White;
            lblColecao1.Name = "lblColecao1";
            this.lblColecao1.Location = new System.Drawing.Point(13, 16);
            this.lblColecao1.TabIndex = 22;
            this.lblColecao1.Text = Share.Collection.CollectionName;
            // 
            // lblColecao1NumTeclados
            // 
            this.lblColecao1NumTeclados.AutoSize = true;
            this.lblColecao1NumTeclados.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecao1NumTeclados.ForeColor = System.Drawing.Color.White;
            this.lblColecao1NumTeclados.Text = "• " + Share.KeyboardsQuantity + " Teclados";
            this.lblColecao1NumTeclados.TabIndex = 23;
            // 
            // colecao1
            // 
            this.colecao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.colecao1.Location = new System.Drawing.Point(2, 47);
            this.colecao1.Size = new System.Drawing.Size(906, 112);
            this.colecao1.TabIndex = 0;
        }
        public System.Windows.Forms.Panel colecao1;
        public System.Windows.Forms.Label lblColecao1;
        public System.Windows.Forms.Label lblColecao1NumTeclados;
        private System.Windows.Forms.PictureBox btnEditarGaleria;
        private System.Windows.Forms.PictureBox btnExcluirGaleria;
        #endregion
    }
}
