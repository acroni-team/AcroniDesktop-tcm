using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni
{
    public partial class SplashEscrita : Form
    {
        public SplashEscrita()
        {
            InitializeComponent();
            #region Inicialização do Panel-barra
            Panel p = new Panel();
            p.Height = lblAcroni.Height - 10;
            p.Width = 3;
            p.Dock = DockStyle.Right;
            p.BackColor = Color.FromArgb(242,242,242);
            lblAcroni.Controls.Add(p);
            #endregion

            #region Inicialização do Panel-transversal
            
            #endregion
            writeScript();
        }

        private async void writeScript()
        {
            piscSlash();
            await Task.Delay(1900);
            lblAcroni.Text = "";
            char[] letras = {'A','c','r','o','n','i'};
            for (int i = 0; i < 6; i++)
            {
                lblAcroni.Text += letras[i];
                await Task.Delay(150);
            }
            //for (int p = 0; p < 3;p++)
            //{
            //    await Task.Delay(1000);
            //    lblAcroni.Text += '.';
            //}
            //await Task.Delay(500);
            eraseScript();
        }

        private async void eraseScript()
        {
            piscSlash();
            await Task.Delay(1900);
            //for (int a = 8; a >= 0; a--)
            //{
            //    await Task.Delay(400);
            //    lblAcroni.Text = lblAcroni.Text.Remove(a);
            //}
            for (int a = 5; a >= 0; a--)
            {
                lblAcroni.Text = lblAcroni.Text.Remove(a);
                await Task.Delay(150);
            }
            //await Task.Delay(500);
            writeScript();
        }

        private async void piscSlash()
        {
            for (int ps = 0; ps < 2; ps++)
            {    
                //MessageBox.Show(lblAcroni.GetNextControl(new Label(), true).GetType().ToString());
                (lblAcroni.GetNextControl(new Label(), true) as Panel).Visible = false;
                await Task.Delay(500);
                
                (lblAcroni.GetNextControl(new Label(), true) as Panel).Visible = true;
                await Task.Delay(500);
            }   
        }
        //private async void fadeIn()
        //{
        //    for () {
        //        await Task.Delay(150);
        //        lblAcroni
        //    }
        //}
    }
}
