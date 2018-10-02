using AcroniLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls.CustomizingModules
{
    public partial class KeycapTextModule : KeycapParentModule
    {
        public KeycapTextModule()
        {
            InitializeComponent();
        }

        //Declaração dos textos para aplicá-los às keycaps do teclado

        public string Uppertext { get; set; }

        public string Maintext { get; set; }

        public string Bottomtext { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Fade.FadeOut(this);
        }

        private void GeneralTextChanged(object sender, EventArgs e)
        {
            if (sender == txt1)
                Uppertext = txt1.Text;
            else if (sender == txt2)
                Maintext = txt2.Text;
            else
                Bottomtext = txt3.Text;
        }

        #region Métodos de transição de cores dos textboxes
        private void GeneralMouseMove(object sender, MouseEventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(42, 45, 50);
                txt1.BackColor = Color.FromArgb(42, 45, 50);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(42, 45, 50);
                txt2.BackColor = Color.FromArgb(42, 45, 50);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(42, 45, 50);
                txt3.BackColor = Color.FromArgb(42, 45, 50);
            }
            Cursor = Cursors.IBeam;
        }

        private void GeneralMouseLeave(object sender, EventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.Default;
        }

        private void GeneralMouseUp(object sender, MouseEventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.IBeam;
        }

        private void GeneralMouseDown(object sender, MouseEventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.IBeam;
        }

        private void GeneralMouseClick(object sender, MouseEventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.IBeam;
        }

        private void GeneralClick(object sender, EventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.IBeam;
        }

        private void GeneralEnter(object sender, EventArgs e)
        {
            if (sender == txt1 || sender == apnlTextbox1)
            {
                apnlTextbox1.BackColor = Color.FromArgb(38, 41, 45);
                txt1.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt2 || sender == apnlTextbox2)
            {
                apnlTextbox2.BackColor = Color.FromArgb(38, 41, 45);
                txt2.BackColor = Color.FromArgb(38, 41, 45);
            }
            else if (sender == txt3 || sender == apnlTextbox3)
            {
                apnlTextbox3.BackColor = Color.FromArgb(38, 41, 45);
                txt3.BackColor = Color.FromArgb(38, 41, 45);
            }
            Cursor = Cursors.IBeam;
        }
        #endregion
    }
}
