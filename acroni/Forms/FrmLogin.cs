using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using acroni.Forms.Seleção_do_teclado;

namespace acroni.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Objetos do banco
        //Usuário para lançar o script do banco: (Usuário: Acroni, Senha: Acroni7)
        SqlConnection conexão_SQL = new SqlConnection(Classes_internas.Conexao.nome_conexao);
        SqlCommand comando_SQL;
        #endregion

        #region Métodos para o botão 'sair'
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

        #endregion

        SelecionarTeclado selecionarTeclado = new SelecionarTeclado();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //--Abrindo a conexão
                if (conexão_SQL.State != ConnectionState.Open)
                    conexão_SQL.Open();

                //--Criando um comando SELECT e chamando sua resposta
                String select_usuario = "SELECT senha FROM tblCliente WHERE usuario='" + txtEntrar.Text + "'";
                comando_SQL = new SqlCommand(select_usuario, conexão_SQL);
                SqlDataReader resposta_usuario = comando_SQL.ExecuteReader();

                //--Checando se houve algum valor que retornou
                if (resposta_usuario.HasRows)
                {
                    resposta_usuario.Close();
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
                                selecionarTeclado.Show();
                                Classes_internas.Conexao.nome_usuario = txtEntrar.Text;

                            }
                            else
                            {
                                lblAviso.Text = "A senha está incorreta";
                                lblAviso.Visible = true;
                                resposta.Close();
                            }
                        }
                        else
                        {
                            lblAviso.Text = "A senha está incorreta";
                            lblAviso.Visible = true;
                            resposta.Close();
                        }

                        //--Fechando a conexão
                        conexão_SQL.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexão_SQL.Close();
                    }
                }
                else
                {
                    lblAviso.Text = "Este usuário não existe";
                    lblAviso.Visible = true;
                    resposta_usuario.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexão_SQL.Close();
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
            {
                this.Show();
            }
            else
                this.Close();
        }

        private void lnklblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Atualizadores.FrmUsuario frmAt = new Atualizadores.FrmUsuario();
            frmAt.ShowDialog();
            //if (!Cadastro.FrmConfirmarEmail.atualizacao_SUCCESS)
            this.Show();
            //else
            //this.Close();
        }
    }
}

