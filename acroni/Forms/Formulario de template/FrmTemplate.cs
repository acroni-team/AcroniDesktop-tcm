using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni.Forms.Formulario_de_template
{
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }

        #region Métodos para o botão 'sair'
        private void btnSair_MouseMove(object sender, MouseEventArgs e)
        {
            btnSair.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.Font = new System.Drawing.Font("Century Gothic", 11F, FontStyle.Bold);
        }

        #endregion

        #region Métodos para transição de cores dos botões do menu


        private void bunifuImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(238, 63, 63);
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

        #region Ações dos botões do menuStrip

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
