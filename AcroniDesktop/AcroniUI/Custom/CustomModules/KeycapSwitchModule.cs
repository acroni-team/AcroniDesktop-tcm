using AcroniControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI.Custom.CustomModules
{
    public partial class KeycapSwitchModule : KeycapParentModule
    {
        public KeycapSwitchModule()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse e = new Bunifu.Framework.UI.BunifuElipse();
            foreach (Control c in this.Controls)
            {
                if (!(c is Label))
                {
                    e.ApplyElipse(c, 5);
                }
            }
        }

        public Color SwitchColor { get; set; }

        private void SwitchPicture_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                this.Controls[(sender as PictureBox).Name.Replace("pic", "btn")].BackColor = Color.FromArgb(80, 80, 80);
                (sender as PictureBox).BackColor = Color.FromArgb(80, 80, 80);
            }
        }

        private void SwitchPicture_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                this.Controls[(sender as PictureBox).Name.Replace("pic", "btn")].BackColor = Color.FromArgb(31, 32, 34);
                (sender as PictureBox).BackColor = Color.FromArgb(31, 32, 34);
            }
        }

        private void SwitchButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is StyleBtn)
            {
                this.Controls[(sender as StyleBtn).Name.Replace("btn", "pic")].BackColor = Color.FromArgb(80, 80, 80);
                (sender as StyleBtn).BackColor = Color.FromArgb(80, 80, 80);
            }
        }

        private void SwitchButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is StyleBtn)
            {
                this.Controls[(sender as StyleBtn).Name.Replace("btn", "pic")].BackColor = Color.FromArgb(31, 32, 34);
                (sender as StyleBtn).BackColor = Color.FromArgb(31, 32, 34);
            }
        }

        private void ChosingSwitch_Click(object sender, EventArgs e)
        {
            if (sender is StyleBtn)
            {
                object temp = this.Controls[(sender as StyleBtn).Name.Replace("btn", "pic")];
                sender = null;
                sender = temp;
            }

            else if (sender is PictureBox)
            {
                PictureBox Switch = (PictureBox)sender;

                if (Switch.Tag.Equals("Chosen"))
                {
                    Switch.Tag = "Not chosen";
                    pnlBtnIconChosen.Visible = false;
                    Switch = null;
                }
                else
                {
                    Switch.Tag = "Chosen";
                    pnlBtnIconChosen.Visible = true;
                    pnlBtnIconChosen.Location = new Point(Switch.Location.X + Switch.Size.Width - 10, Switch.Location.Y + Switch.Size.Height - 10);
                    pnlBtnIconChosen.BringToFront();

                    if (Switch == picswitch1)
                        SwitchColor = Color.Black;
                    else if (Switch == picswitch2)
                        SwitchColor = Color.FromArgb(1, 175, 217);
                    else if (Switch == picswitch3)
                        SwitchColor = Color.FromArgb(128, 52, 1);
                    else if (Switch == picswitch4)
                        SwitchColor = Color.FromArgb(51, 181, 78);
                    else if (Switch == picswitch5)
                        SwitchColor = Color.FromArgb(209, 17, 12);
                }
            }
        }
    }
}
