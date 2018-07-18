using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni.Atualizadores
{
    public partial class FrmSenha : Form
    {
        public FrmSenha()
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
                    String select = "SELECT usuario,senha FROM tblCliente WHERE usuario IN ('" + txtUsuario.Text + "')";
                    comando_SQL = new SqlCommand(select, conexao_SQL);
                    SqlDataReader tem_usuario = comando_SQL.ExecuteReader();

                    //--Lendo a resposta
                    tem_usuario.Read();

                    //-- ".HasRows" é uma propriedade que mostra se teve alguma resposta
                    if (tem_usuario[0].Equals(txtUsuario.Text))
                    {
                        if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                        {
                            if (txtSenha.Text.Equals(tem_usuario[1]))
                            {
                                lblAviso.Text = "Senhas não podem se repetir";
                                lblAviso.Visible = true;
                            }
                            else
                            {
                                try
                                {
                                    //--Abrindo a conexão
                                    if (conexao_SQL.State != ConnectionState.Open)
                                        conexao_SQL.Open();

                                    //--Fechando o SELECT para poder reutilizar
                                    tem_usuario.Close();

                                    //--Inicializando um comando UPDATE e execuntando
                                    String update = "UPDATE tblCliente SET senha = '" + txtSenha.Text + "' WHERE usuario = '" + txtUsuario.Text + "'";
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
                                        txtRepetirSenha.ResetText(); txtSenha.ResetText(); txtUsuario.ResetText();
                                    }
                                    //--Fechando a conexão (NÃO ESQUECER!)
                                    conexao_SQL.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                    //--Fechando o SELECT para poder reutilizar
                                    tem_usuario.Close();
                                }
                            }
                            }
                            else
                            {
                                lblAviso.Text = "As senhas não são iguais";
                                lblAviso.Visible = true;
                            }

                        //--Fechando o SELECT para poder reutilizar
                        tem_usuario.Close();
                    }
                        else
                        {
                            lblAviso.Text = "Este usuário não existe";
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

        private void lnklblEsqueceuUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Atualizadores.FrmUsuario frmAt = new Atualizadores.FrmUsuario();
            frmAt.ShowDialog();
            if (!Atualizadores.FrmUsuario.atualizacao_SUCCESS)
                this.Show();
            else
                this.Close();
        }
    }
}
