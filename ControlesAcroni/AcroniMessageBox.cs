using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAcroni
{
    public partial class AcroniMessageBox : Form
    {
        public AcroniMessageBox(String mensagem)
        {
            InitializeComponent();
            alblMensagem.Text = mensagem;
        }
        public AcroniMessageBox(String mensagem, String texto_opcao1, String texto_opcao2)
        {
            InitializeComponent();
            alblMensagem.Text = mensagem;
            btnOpcao1.Text = texto_opcao1;
            btnOpcao2.Text = texto_opcao2;
        }

        public bool confirmacao { get; set; } = false;
        private void btnClose(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name.Contains("1"))
                confirmacao = true;
            else
                confirmacao = false;
            this.Close();
        }
    }
}
