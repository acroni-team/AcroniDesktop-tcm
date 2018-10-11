using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class AcroniMessageBoxConfirm : Form
    {
        Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();

        public AcroniMessageBoxConfirm(string message)
        {
            InitializeComponent();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse(btnCancela, 5);
            ellipse.ApplyElipse(btnOk, 5);
            btnCancela.Cursor = Cursors.Hand;
            btnOk.Cursor = Cursors.Hand;
            alblMessage1.Text = message;
            alblMessage2.Text = "";
        }

        public AcroniMessageBoxConfirm(string message, string message2)
        {
            InitializeComponent();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse(btnCancela, 5);
            ellipse.ApplyElipse(btnOk, 5);
            btnCancela.Cursor = Cursors.Hand;
            btnOk.Cursor = Cursors.Hand;
            alblMessage1.Text = message;
            alblMessage2.Text = message2;
        }

        public AcroniMessageBoxConfirm(string message, string message2, string buttonAcceptMessage)
        {
            InitializeComponent();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse(btnCancela, 5);
            ellipse.ApplyElipse(btnOk, 5);
            btnCancela.Cursor = Cursors.Hand;
            btnOk.Cursor = Cursors.Hand;
            alblMessage1.Text = message;
            alblMessage2.Text = message2;
            btnOk.Text = buttonAcceptMessage;
        }
        public AcceptButtons ButtonClicked { get; set; }
        private void btnCancela_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancela.Font = new Font("Open Sans", 12.5F, FontStyle.Underline);
        }

        private void btnCancela_MouseLeave(object sender, EventArgs e)
        {
            btnCancela.Font = new Font("Open Sans", 12.5F, FontStyle.Regular);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ButtonClicked = AcceptButtons.OK;
            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            ButtonClicked = AcceptButtons.CANCEL;
            this.Close();
        }
    }
    public enum AcceptButtons
    {
        OK = 1,
        CANCEL = 2
    }
}
