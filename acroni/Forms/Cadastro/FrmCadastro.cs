using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        SqlConnection conexao_SQL = new SqlConnection(Classes_internas.Conexao.nome_conexao);
        SqlCommand comando_SQL;
        Regex validacao_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!possuiCamposVazios())
            {
                if (validacao_email.IsMatch(txtEmail.Text))
                {
                    try
                    {
                        //--Abrindo a conexão
                        if (conexao_SQL.State != ConnectionState.Open)
                            conexao_SQL.Open();

                        //--Inicializando um comando SELECT para ver se aquele nome já existe
                        String select = "SELECT email FROM tblCliente WHERE email IN ('" + txtEmail.Text + "')";
                        comando_SQL = new SqlCommand(select, conexao_SQL);
                        SqlDataReader tem_email = comando_SQL.ExecuteReader();

                        //--Lendo a resposta
                        tem_email.Read();

                        //-- ".HasRows" é uma propriedade que mostra se teve alguma resposta
                        if (!tem_email.HasRows)
                        {
                            //--Fechando o SELECT para poder reutilizar
                            tem_email.Close();

                            //--Abrindo uma nova conexão
                            if (conexao_SQL.State != ConnectionState.Open)
                                conexao_SQL.Open();

                            //--Inicializando um comando SELECT para ver se aquele nome já existe
                            String select_usuario = "SELECT usuario FROM tblCliente WHERE usuario IN ('" + txtUsuario.Text + "')";
                            comando_SQL = new SqlCommand(select_usuario, conexao_SQL);
                            SqlDataReader tem_usuario = comando_SQL.ExecuteReader();

                            //--Lendo a resposta
                            tem_usuario.Read();

                            //-- ".HasRows" é uma propriedade que mostra se teve alguma resposta
                            if (!tem_usuario.HasRows)
                            {
                                //--Fechando o SELECT para poder reutilizar
                                tem_usuario.Close();

                                if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                                {
                                    ControlesAcroni.AcroniMessageBox confirmacao_nulabilidade = new ControlesAcroni.AcroniMessageBox("Desejas tu prosseguir sem colocar uma imagem de perfil?!");
                                    if (fotoCliente.Image == null)
                                    {
                                        confirmacao_nulabilidade.ShowDialog();
                                    }
                                    //cadastro_SUCCESS = true;
                                    Classes_internas.Conexao.nome_usuario = txtUsuario.Text;
                                    this.Hide();
                            FrmConfirmarEmail frm = new FrmConfirmarEmail(txtUsuario.Text, txtSenha.Text, txtEmail.Text, "cadastro", (confirmacao_nulabilidade.confirmacao == true ? acroni.Properties.Resources.imagem_padrao_temporaria : fotoCliente.Image), loc_img);
                            frm.ShowDialog();
                            if (FrmConfirmarEmail.atualizacao_SUCCESS)
                            {
                                this.Close();
                                        Classes_internas.Conexao.imagem_cliente = (confirmacao_nulabilidade.confirmacao == true ? acroni.Properties.Resources.imagem_padrao_temporaria : fotoCliente.Image);
                        }
                        else
                        {
                            this.Show();
                            txtEmail.ResetText(); txtRepetirSenha.ResetText(); txtSenha.ResetText(); txtUsuario.ResetText(); fotoCliente.Image = null;
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
                                lblAviso.Text = "Este nome de usuário já existe";
                                lblAviso.Visible = true;

                                //--Fechando o SELECT para poder reutilizar
                                tem_usuario.Close();
                                conexao_SQL.Close();
                            }
                        }
                        else
                        {
                            lblAviso.Text = "Este email está em outra conta";
                            lblAviso.Visible = true;

                            //--Fechando o SELECT para poder reutilizar
                            tem_email.Close();
                            conexao_SQL.Close();
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
                    lblAviso.Text = "O email não é valido";
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
            if (!visibilidae_1)
            txtSenha.isPassword = true;
        }

        private void txtRepetirSenha_OnValueChanged(object sender, EventArgs e)
        {
            if (!visibilidae_2)
            txtRepetirSenha.isPassword = true;
        }

        private String loc_img = @"..\Proprities\Resources\imagem_padrao_temporaria.png";
        private void btnProcurarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                //--Abrindo o explorador de arquivos para selecionar uma imagem
                OpenFileDialog procurador_de_imagens = new OpenFileDialog();
                procurador_de_imagens.Filter = "Arquivos JPG (*.jpg)|*.jpg|Arquivos GIF (*.gif)|*.gif|Arquivos PNG (*.png)|*.png|Todos arquivos (*.*)|*.*";
                procurador_de_imagens.Title = "Selecione uma Imagem :D";

                //--Checando se foi selecionado alguma imagem
                if (procurador_de_imagens.ShowDialog() == DialogResult.OK)
                {
                    fotoCliente.ImageLocation = procurador_de_imagens.FileName.ToString();
                    loc_img = procurador_de_imagens.FileName.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool visibilidae_1 = false, visibilidae_2 = false;
        private void pnlVisibiladade1_Click(object sender, EventArgs e)
        {
            if (!visibilidae_1)
            {
                pnlVisibilidade1.BackgroundImage = acroni.Properties.Resources.icons8_invisible_30;
                txtSenha.isPassword = false;
                visibilidae_1 = true;
            }else
            {
                pnlVisibilidade1.BackgroundImage = acroni.Properties.Resources.icons8_eye_30;
                txtSenha.isPassword = true;
                visibilidae_1 = false;
            }
        }

        private void pnlVisibilidade2_Click(object sender, EventArgs e)
        {
            if (!visibilidae_2)
            {
                pnlVisibilidade2.BackgroundImage = acroni.Properties.Resources.icons8_invisible_30;
                txtRepetirSenha.isPassword = false;
                visibilidae_2 = true;
            }
            else
            {
                pnlVisibilidade2.BackgroundImage = acroni.Properties.Resources.icons8_eye_30;
                txtRepetirSenha.isPassword = true;
                visibilidae_2 = false;
            }
        }
    }
}