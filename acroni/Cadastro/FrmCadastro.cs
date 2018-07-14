using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace acroni.Cadastro
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //--Propriedade para checar se o cadastro foi concluido ou não no form Login
        public static bool cadastro_SUCCESS = false;

        //--Inicializando uma conexão e um COMANDO
        SqlConnection conexao_SQL = new SqlConnection("Data Source =" + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");
        SqlCommand comando_SQL;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!possuiCamposVazios())
            {
                if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                {
                    try
                    {
                        //--Abrindo a conexão
                        if (conexao_SQL.State != ConnectionState.Open)
                            conexao_SQL.Open();

                        //--Inicializando um comando INSERT e execuntando
                        String insert = "INSERT INTO tblCliente VALUES ('" + txtUsuario.Text + "','" + txtSenha.Text + "','" + txtEmail.Text + "')";
                        comando_SQL = new SqlCommand(insert, conexao_SQL);
                        //--Para executar, utilizo ExecuteNonQuery(), pois ele retorna apenas o numero de linhas afetadas
                        int n_linhas_afetadas = comando_SQL.ExecuteNonQuery();

                        if (n_linhas_afetadas > 0)
                        {
                            MessageBox.Show("Cadastro concluido");
                            cadastro_SUCCESS = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cadastro não foi concluido com SUCCESS");
                            txtEmail.ResetText(); txtRepetirSenha.ResetText(); txtSenha.ResetText(); txtUsuario.ResetText();
                        }
                        //--Fechando a conexão (NÃO ESQUECER!)
                        conexao_SQL.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else
                {
                    lblAviso.Text = "As senhas não são iguais";
                    lblAviso.Visible = true;
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