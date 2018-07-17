using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace acroni.Atualizadores
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
        SqlConnection conexao_SQL = new SqlConnection(Colorpicker.ColorpickerHandlers.nome_conexao);
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
                    String select = "SELECT usuario FROM tblCliente WHERE usuario IN ('" + txtUsuario.Text + "')";
                    comando_SQL = new SqlCommand(select, conexao_SQL);
                    SqlDataReader tem_usuario = comando_SQL.ExecuteReader();

                    //--Lendo a resposta
                    tem_usuario.Read();

                    //-- ".HasRows" é uma propriedade que mostra se teve alguma resposta
                    if (!tem_usuario.HasRows)
                    {
                        //--Fechando o SELECT para poder reutilizar
                        tem_usuario.Close();
                        if (validacao_email.IsMatch(txtEmail.Text))
                        {
                            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                            {
                                try
                                {
                                    //--Abrindo a conexão
                                    if (conexao_SQL.State != ConnectionState.Open)
                                        conexao_SQL.Open();

                                    //--Inicializando um comando UPDATE e execuntando
                                    String update = "UPDATE tblCliente SET usuario = '" + txtUsuario.Text + "',senha = '" + txtSenha.Text + "' WHERE email = '" + txtEmail.Text + "'";
                                    comando_SQL = new SqlCommand(update, conexao_SQL);
                                    //--Para executar, utilizo ExecuteNonQuery(), pois ele retorna apenas o numero de linhas afetadas
                                    int n_linhas_afetadas = comando_SQL.ExecuteNonQuery();

                                    if (n_linhas_afetadas > 0)
                                    {
                                        MessageBox.Show("Atualização concluida");
                                        Colorpicker.ColorpickerHandlers.nome_usuario = txtUsuario.Text;
                                        atualizacao_SUCCESS = true;
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Atualização não foi concluida com SUCCESSO");
                                        txtEmail.ResetText(); txtRepetirSenha.ResetText(); txtSenha.ResetText(); txtUsuario.ResetText();
                                    }
                                    //--Fechando a conexão (NÃO ESQUECER!)
                                    conexao_SQL.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                lblAviso.Text = "As senhas não são iguais";
                                lblAviso.Visible = true;
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
                        lblAviso.Text = "Não se repete o nome dos usuários";
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
    }
}
