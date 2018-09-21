using System.Windows.Forms;

namespace AcroniControls
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        private void btnOpcao2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
