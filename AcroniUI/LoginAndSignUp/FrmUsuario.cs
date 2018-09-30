using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AcroniLibrary;

namespace AcroniUI.LoginAndSignUp
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static bool atualizacao_SUCCESS { get; set; } = false;
        SqlConnection conexao_SQL = new SqlConnection(SQLConnection.nome_conexao);
        SqlCommand comando_SQL;
        Regex validacao_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!possuiCamposVazios())
            {
                try
                {
                    //--Abrindo a conexão
                    if (conexao_SQL.State != ConnectionState.Open)
                        conexao_SQL.Open();

                    //--Inicializando um comando SELECT para ver se aquele nome já existe
                    String select = "SELECT senha FROM tblCliente WHERE senha IN ('" + txtSenha.Text + "')";
                    comando_SQL = new SqlCommand(select, conexao_SQL);
                    SqlDataReader tem_senha = comando_SQL.ExecuteReader();

                    //--Lendo a resposta
                    tem_senha.Read();

                    //-- ".HasRows" é uma propriedade que mostra se teve alguma resposta
                    if (!tem_senha.HasRows)
                    {
                        //--Fechando o SELECT para poder reutilizar
                        tem_senha.Close();
                        if (validacao_email.IsMatch(txtEmail.Text))
                        {
                            try
                            {
                                String select_email = "SELECT email FROM tblCliente WHERE email IN ('"+txtEmail.Text+"')";
                                comando_SQL = new SqlCommand(select_email, conexao_SQL);
                                SqlDataReader email_existente = comando_SQL.ExecuteReader();

                                if (email_existente.HasRows)
                                {
                                    if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                                    {
                                        this.Hide();
                                        FrmConfirmarEmail frm = new FrmConfirmarEmail("não_possui", txtSenha.Text, txtEmail.Text, "senha");
                                        
                                        frm.ShowDialog();
                                        
                                        if (FrmConfirmarEmail.atualizacao_SUCCESS)
                                            this.Close();
                                        else
                                        {
                                            this.Show();
                                            txtEmail.ResetText(); txtRepetirSenha.ResetText(); txtSenha.ResetText();
                                        }
                                    }
                                    else
                                    {
                                        lblAviso.Text = "As senhas não são iguais";
                                        lblAviso.Visible = true;
                                    }
                                }else
                                {
                                    email_existente.Close();
                                    lblAviso.Text = "Este email não existe";
                                    lblAviso.Visible = true;
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else
                        {
                            lblAviso.Text = "O email não é valido";
                            lblAviso.Visible = true;
                        }
                    }
                    else
                    {
                        tem_senha.Close();
                        lblAviso.Text = "Não se repete a mesma senha que esqueceu";
                        lblAviso.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexao_SQL.Close();
                }
            }
            else
            {
                lblAviso.Text = "Existem campos vazios";
                lblAviso.Visible = true;
            }
        }
        //--Método que checa se o Form possui campos vazios
        private bool possuiCamposVazios()
        {
            bool b = false;
            foreach (Control controle in Controls)
            {
                if (controle is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    if ((controle as Bunifu.Framework.UI.BunifuMaterialTextbox).Text.Equals(String.Empty))
                    {
                        b = true;
                        break;
                    }
                }
            }
            return b;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void txtRepetirSenha_OnValueChanged(object sender, EventArgs e)
        {
            txtRepetirSenha.isPassword = true;
        }
    }
}
