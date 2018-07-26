using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static FormsDesign.FormDrag;
using System.Drawing;

namespace acroni.Layout_Master
{
    public partial class LayoutMaster : Form
    {
        public LayoutMaster()
        {
            InitializeComponent();
            #region Atribuição de Dragging aos controles e no próprio form 

            ///<summary> 
            /// Esses métodos não foram gerados automaticamente. Trata-se duma maneira de permitir que não apenas o formulário seja arrastável, mas os controles também. 
            ///</summary>
            ///
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(Form_MouseDown);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(Form_MouseMove);
            }
            #endregion
        }

        #region Métodos de abrir formulários
        protected virtual void btnAbrirGaleria_Click(object sender, EventArgs e)
        {
            // Eu sinceramente não tenho boas ideias de como abrir isso nos dois forms derivados. 
        }

        protected virtual void btnAbrirAcroni_Click(object sender, EventArgs e)
        {
            // Isso também não.
        }
        #endregion


        public void trocar_nome_usuario(String usuario)
        {
            lblNomeUsuario.Text = usuario;
        }

        #region Métodos para transição de cores do botão 
        private void bunifuImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(238, 63, 63);
        }

        private void bunifuImageButton2_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(166, 169, 173);
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(47, 47, 47);
        }

        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void ajudaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

    }
}