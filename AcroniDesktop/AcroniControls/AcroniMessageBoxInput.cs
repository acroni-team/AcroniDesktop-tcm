using AcroniLibrary.FileInfo;
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
            doBasic();
            alblMessage1.Text = message;
            alblMessage2.Text = "";
        }

        public AcroniMessageBoxInput(string message, string message2)
        {
            InitializeComponent();
            doBasic();
            alblMessage1.Text = message;
            alblMessage2.Text = message2;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserInput.Text))
            {
                if (alblMessage1.Text.Contains("coleção"))
                    Share.Collection.CollectionName = txtUserInput.Text;
                else
                    Share.KeyboardNameNotCreated = txtUserInput.Text;
                this.Close();
            }
        }
    }
}
