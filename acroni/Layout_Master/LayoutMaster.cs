using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace acroni.Layout_Master
{
    public partial class LayoutMaster : Form
    {
        public LayoutMaster()
        {
            InitializeComponent();
        }

        private void lblFecharForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void btnAbrirGaleria_Click(object sender, EventArgs e)
        {
            // Eu sinceramente não tenho boas ideias de como abrir isso nos dois forms derivados. 
        }

        protected virtual void btnAbrirAcroni_Click(object sender, EventArgs e)
        {
            // Isso também não.
        }
        
        public void trocar_nome_usuario(String usuario)
        {
            lblNomeUsuario.Text = usuario;
        }
    }
}