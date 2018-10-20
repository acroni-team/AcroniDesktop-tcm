using AcroniLibrary.FileInfo;
using System;
using System.Drawing;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInput_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = global::AcroniControls.Properties.Resources.fundobotaoclaro;
        }

        private void btnInput_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = global::AcroniControls.Properties.Resources.fundo_botao;
        }

        private void txtUserInput_MouseMove(object sender, MouseEventArgs e)
        {
            txtUserInput.BackColor = Color.FromArgb(38, 41, 45);
            apnlTextbox.BackColor = Color.FromArgb(38, 41, 45);
        }
    }
}
