using System;
using System.Windows.Forms;

namespace AcroniControls
{
    public partial class AcroniMessageBoxInput : Form
    {
        private void doBasic()
        {
            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            ellipse.ApplyElipse(this, 15);
            ellipse.ApplyElipse();
            btnEnviar.Cursor = Cursors.Hand;
            apnlTextbox.Cursor = Cursors.IBeam;
        }

        public AcroniMessageBoxInput(string message)
        {
            InitializeComponent();
            alblMessage1.Text = message;
        }

        public AcroniMessageBoxInput(string message, string message2)
        {
            InitializeComponent();
            alblMessage1.Text = message;
            alblMessage2.Text = message2;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (alblMessage1.Text.Contains("coleção"))
                SetNames.colecao = txtUserInput.Text;
            else
                SetNames.teclado = txtUserInput.Text;
            this.Close();
        }
    }
}
