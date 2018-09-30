using System;
using System.Drawing;
using System.Windows.Forms;
using FormsDesign;
using System.Drawing.Text;
using System.Threading.Tasks;
using AcroniControls;

namespace AcroniUI
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(btnSair, 9);
            #region Atribuição de fontes definidas (open sans, qanelas) ao layout 

            #endregion
            #region Atribuição de Dragging aos controles e no próprio form 

            ///<summary> 
            /// Esses métodos não foram gerados automaticamente. Trata-se duma maneira de permitir que não apenas o formulário seja arrastável, mas os controles também. 
            ///</summary>
            ///
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseDown);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseMove);
            }
            #endregion    
        }

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

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {
            Rectangle areaBorda = pnlSuperior.ClientRectangle;
            Rectangle formBorda = this.ClientRectangle;
            areaBorda.Width--;
            areaBorda.Height--;
            formBorda.Width--;
            formBorda.Height--;
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(38, 39, 41)), 3), areaBorda);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(38, 39, 41)), 3), formBorda);
        }

        #region Sair e minimizar
        private void btnClose_Click(object sender, EventArgs e)
        {
            AcroniMessageBoxConfirm ambc = new AcroniMessageBoxConfirm("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Você quer mesmo sair? Não se esqueça de salvar o seu teclado ;)");
            ambc.ShowDialog();
            if (ambc.DialogResult == DialogResult.Yes)
                timerFade.Start();
            else
                ambc.Dispose();

        }

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        #endregion
        #region Timers
        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0.0)
            {
                Opacity -= 0.1;
            }
            else
            {
                timerFade.Stop();
                Application.Exit();
            }
        }
        #endregion
    }
}
