using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcroniControls
{
    public partial class AcroniMessageBoxInput : MessageBox
    {
        public AcroniMessageBoxInput(string msg)
        {
            InitializeComponent();
            this.alblMensagem.Text = msg;
        }
        public void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtTeclado.Text != "")
            {
                if (alblMensagem.Text.Contains("teclado"))
                    SetNames.teclado = txtTeclado.Text;
                else
                    SetNames.colecao = txtTeclado.Text;
                this.Hide();
            }
        }
        public void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public AcroniMessageBoxInput(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
