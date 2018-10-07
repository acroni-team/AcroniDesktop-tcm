using System;
using System.Drawing;
using System.Windows.Forms;
using FormsDesign;
using AcroniControls;
using AcroniLibrary;

namespace AcroniUI
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
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

        #region Ações dos botões do pnlSuperior

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
            {
                Fade.FadeOut(this);
                Application.Exit();
            }
                
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
        #region UX dos itens do menuStrip
        private void menuStripItems_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            tsmi.BackColor = Color.FromArgb(41, 42, 47);
            Cursor = Cursors.Hand;
        }

        private void menuStripItems_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion
    }
}
