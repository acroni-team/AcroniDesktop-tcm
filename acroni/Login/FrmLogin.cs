using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace acroni.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_MouseMove(object sender, MouseEventArgs e)
        {
            btnSair.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.Font = new System.Drawing.Font("Century Gothic", 11F, FontStyle.Bold);
        }
        //Por favor, criar esse usário no computador de vocês (Usuário: Acroni, Senha: Acroni7)
        SqlConnection conexão_SQL = new SqlConnection("Data Source =" + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");
        SqlCommand comando_SQL;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //--Abrindo a conexão
                if (conexão_SQL.State != ConnectionState.Open)
                    conexão_SQL.Open();

                //--Criando um comando SELECT e chamando sua resposta
                String select = "SELECT senha FROM tblCliente WHERE usuario='" + txtEntrar.Text + "'";
                comando_SQL = new SqlCommand(select, conexão_SQL);
                SqlDataReader resposta = comando_SQL.ExecuteReader();

                //--Checando se houve algum valor que retornou
                if (resposta.HasRows)
                {
                    //--Lendo a resposta
                    resposta.Read();

                    //Para pegar os valores, trate a resposta como uma Array
                    if (resposta[0].ToString().Equals(txtSenha.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        lblAviso.Visible = true;
                    }
                }
                else
                {
                    lblAviso.Visible = true;
                }

                //--Fechando a conexão
                conexão_SQL.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro.FrmCadastro fc = new Cadastro.FrmCadastro();
            fc.ShowDialog();
            if (!Cadastro.FrmCadastro.cadastro_SUCCESS)
                this.Show();
            else
                this.Close();
        }

    }
}

