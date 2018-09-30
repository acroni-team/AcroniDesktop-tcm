using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class AcroniMessageBoxInput : Form
    {
        public AcroniMessageBoxInput(string message)
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse();
            btnEnviar.Cursor = Cursors.Hand;
            apnlTextbox.Cursor = Cursors.IBeam;
            alblMessage1.Text = message;
        }

        public AcroniMessageBoxInput(string message, string message2)
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse();
            btnEnviar.Cursor = Cursors.Hand;
            apnlTextbox.Cursor = Cursors.IBeam;
            alblMessage1.Text = message;
            alblMessage2.Text = message2;
        }
    }
}
