using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using AcroniLibrary.DesignMethods;
using AcroniControls;

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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(FormDrag.Form_MouseMove);
            #endregion

        }

        #region Ações dos botões do pnlSuperior

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FadeOut();
        }

        private void pnlStripAjuda_MouseEnter(object sender, EventArgs e)
        {
            lblAjuda.ForeColor = Color.FromArgb(40, 42, 47);
            lblAjuda.BackColor = Color.White;
        }

        private void pnlStripAjuda_MouseLeave(object sender, EventArgs e)
        {
            lblAjuda.ForeColor = Color.White;
            lblAjuda.BackColor = Color.FromArgb(40, 42, 47);
            lblAjuda.MouseLeave += lblMenus_MouseLeave;
            pnlStripAjuda.Visible = false;
        }

        private void lblMenus_MouseOver(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(40, 42, 47);
            ((Label)sender).BackColor = Color.White;
            ((Label)sender).Tag = "selected";
            if (((Label)sender).Equals(lblAjuda))
            {
                pnlStripAjuda.Visible = true;
            }
        }

        private void lblMenus_MouseLeave(object sender, EventArgs e)
        {
            //if (!((Label)sender).Tag.Equals("selected")) {
                ((Label)sender).ForeColor = Color.White;
                ((Label)sender).BackColor = Color.FromArgb(40, 42, 47);
            if (((Label)sender).Equals(lblAjuda))
            {
                pnlStripAjuda.Visible = false;
            }
            //}
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
        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            AcroniMessageBoxConfirm ambc = new AcroniMessageBoxConfirm("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Você quer mesmo sair? Não se esqueça de salvar o seu teclado ;)");
            ambc.ShowDialog();
            if (ambc.DialogResult == DialogResult.Yes)
            {

                FadeOut();
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
        
        private void pnlStripAjuda_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y == 21)
            {
                lblAjuda.MouseLeave -= lblMenus_MouseLeave;
                pnlStripAjuda.Visible = true;
            }
        }

        #region FadeIn e FadeOut
        public async void FadeOut()
        {
            while (Opacity > 0)
            {
                await Task.Delay(1);
                Opacity -= 0.05;
            }
            Application.Exit();
        }

        public async void FadeIn()
        {
            while (Opacity < 1)
            {
                await Task.Delay(1);
                Opacity += 0.05;
            }
            Opacity = 1.0;
        }
        #endregion

        private void Template_Load(object sender, EventArgs e) => FadeIn();
    }
}
