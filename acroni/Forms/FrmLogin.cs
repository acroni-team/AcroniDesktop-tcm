using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using acroni.Forms.Seleção_do_teclado;
using acroni.Forms.Formulario_de_template;

namespace acroni.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0,148,255);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 148, 255);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 148, 255);
        }

        #region Ações dos botões do menuStrip

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Métodos para transição de cores dos botões do menu

        private void btnSair_MouseMove(object sender, MouseEventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(238, 63, 63);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(166, 169, 173);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(47, 47, 47);
        }

        #endregion

        #region Objetos do banco
        //Usuário para lançar o script do banco: (Usuário: Acroni, Senha: acroni7)
        SqlConnection conexão_SQL = new SqlConnection(Classes_internas.Conexao.nome_conexao);
        SqlCommand comando_SQL;
        #endregion

        SelecionarTeclado selecionarTeclado;

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
                                Classes_internas.Conexao.nome_usuario = txtEntrar.Text;
                                selecionarTeclado = new SelecionarTeclado();
                                selecionarTeclado.Show();
                                this.Hide();
                            }
                            else
                            {
                                pnlQueDesce.Location = new Point(854, 446);
                                lblAviso.Text = "A senha está incorreta.";
                                lblAviso.Visible = true;
                                resposta.Close();
                            }
                        }
                        else
                        {
                            pnlQueDesce.Location = new Point(854, 446);
                            lblAviso.Text = "A senha está incorreta.";
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
                    pnlQueDesce.Location = new Point(854, 446);
                    lblAviso.Text = "Este usuário não existe.";
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

        private void lnklblCadastrar_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Cadastro.FrmCadastro fc = new Cadastro.FrmCadastro();
            fc.ShowDialog();
            if (Cadastro.FrmCadastro.cadastro_SUCCESS)
            {
                this.Hide();
                selecionarTeclado = new SelecionarTeclado();
                selecionarTeclado.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void lnklblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Atualizadores.FrmUsuario frmAt = new Atualizadores.FrmUsuario();
            frmAt.ShowDialog();
            this.Show();
        }

        bool visibilidade_senha = false;
        private void pnlVisibiladade_Click(object sender, EventArgs e)
        {
            if (!visibilidade_senha)
            {
                    pnlVisibiladade.BackgroundImage = new Bitmap(acroni.Properties.Resources.icons8_eye_30);
                    txtSenha.isPassword = false;
                    visibilidade_senha = true;   
            }
            else
            {
                    pnlVisibiladade.BackgroundImage = new Bitmap(acroni.Properties.Resources.icons8_invisible_30);
                    txtSenha.isPassword = true;
                    visibilidade_senha = false;
            }
        }

        private void txtBoxesLogin_OnValueChanged(object sender, EventArgs e)
        {
            pnlQueDesce.Location = new Point(854, 416);
            Bunifu.Framework.UI.BunifuMaterialTextbox b = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            if (b.Name.Contains("Senha"))
                txtSenha.isPassword = true;
        }
    }
}

