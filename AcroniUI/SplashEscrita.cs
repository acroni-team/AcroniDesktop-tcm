using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class SplashEscrita : Form
    {
        public SplashEscrita()
        {
            InitializeComponent();
            #region Inicialização do Panel-barra
            //Panel p = new Panel();
            //p.Height = 0;
            //p.Width = 1;
            //p.Dock = DockStyle.Right;
            //p.Margin = new Padding(0);
            //p.BackColor = Color.FromArgb(242,242,242);
            //lblAcroni.Controls.Add(p);
            #endregion
            writeScript();
        }

        private async void writeScript()
        {
            piscSlash();
            await Task.Delay(1900);
            lblAcroni.Text = "";
            bool fisrt_time = true;
            foreach (char c in "Acroni")
            {
                lblAcroni.Text = lblAcroni.Text + c;
                pnlSlash.Location = (fisrt_time) ? new Point(pnlSlash.Location.X + lblAcroni.Width - 10, pnlSlash.Location.Y) : new Point(lblAcroni.Width + lblAcroni.Location.X - 10,pnlSlash.Location.Y);
                fisrt_time = false;
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
            int last = lblAcroni.Width;
            for (int a = 5; a >= 0; a--)
            {
                lblAcroni.Text = lblAcroni.Text.Remove(a);
                pnlSlash.Location = (a > 0)? new Point(pnlSlash.Location.X - last + lblAcroni.Width, pnlSlash.Location.Y): new Point(75,77);
                //MessageBox.Show((pnlSlash.Location.X - last + lblAcroni.Width + 10).ToString());
                last = lblAcroni.Width;
                await Task.Delay(150);
            }
            //await Task.Delay(500);
            
            writeScript();
        }

        private async void piscSlash()
        {
            for (int ps = 0; ps < 2; ps++)
            {
                //(lblAcroni.GetNextControl(new Label(), true) as Panel).Visible = false;
                pnlSlash.Visible = false;
                await Task.Delay(500);

                //(lblAcroni.GetNextControl(new Label(), true) as Panel).Visible = true;
                pnlSlash.Visible = true;
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
