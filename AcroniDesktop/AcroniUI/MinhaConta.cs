using AcroniLibrary.Drawing;
using AcroniLibrary.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class MinhaConta : TemplateMenu
    {
        public MinhaConta()
        {
            InitializeComponent();

            pnlEscurecerImg.BackColor = Color.FromArgb(90, pnlEscurecerImg.BackColor);

            ChamarImagemDoBanco();
        }

        private void ChamarImagemDoBanco()
        {

            using (SqlConnection conn = new SqlConnection(SQLConnection.nome_conexao))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand($"select imagem_cliente from tblCliente where usuario like '{SQLConnection.nome_usuario}'", conn))
                {
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        sdr.Read();
                        using (var ms = new MemoryStream((byte[])sdr[0]))
                        {
                            pnlUserImg.BackgroundImage = new Bitmap(ms);
                        }
                    }
                }
            }
        }

        SqlConnection conexao_SQL = new SqlConnection(SQLConnection.nome_conexao);
        SqlCommand comando_SQL;

        Regex validacao_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        private void pnlUserImg_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pnlEscurecerImg_MouseEnter(object sender, EventArgs e)
        {
            pnlEscurecerImg.BackColor = Color.FromArgb(170, pnlEscurecerImg.BackColor);
        }

        private void pnlEscurecerImg_MouseLeave(object sender, EventArgs e)
        {
            pnlEscurecerImg.BackColor = Color.FromArgb(90, pnlEscurecerImg.BackColor);
        }

        //Isso serve para eu só mandar a imagem pro banco quando ele for salvar, e não quando ele simplesmente mudar a imagem.

        private Bitmap bmp;

        private void AlterarImagem(object sender, EventArgs e)
        {
            using (OpenFileDialog profilePic = new OpenFileDialog())
            {
                profilePic.InitialDirectory = @"C:\";
                profilePic.Title = "Qual imagem será sua chamativa foto de perfil?";
                profilePic.Filter = "Todos os tipos de imagem | *jpg; *.jpeg; *.bmp; *.png; *.ico|BMP | *.bmp | JPG | *.jpg; *.jpeg | PNG | *.png | ICO | *.ico | Todos| *.*";
                profilePic.Multiselect = false;
                if (profilePic.ShowDialog() == DialogResult.OK)
                {
                    bmp = new Bitmap(Image.FromFile(profilePic.FileName));
                    pnlUserImg.BackgroundImage = bmp;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.nome_conexao))
            {
                conn.Open();
                byte[] img = ImageConvert.ImageToByteArray(bmp, ImageFormat.Bmp);

                using (SqlCommand comm = new SqlCommand($"update tblCliente set imagem_cliente = @img where usuario like '{SQLConnection.nome_usuario}'", conn))
                {
                    comm.Parameters.AddWithValue("@img", img);
                    comm.ExecuteNonQuery();
                }
            }
        }

        private void MinhaConta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Tag.Equals("not salvo"))
            {
                AcroniControls.AcroniMessageBoxConfirm a = new AcroniControls.AcroniMessageBoxConfirm("Você tem certeza que deseja sair sem salvar?");

                if (a.ShowDialog() == DialogResult.Yes)
                    ChamarImagemDoBanco();
                else
                {
                    MinhaConta mc = new MinhaConta();
                    mc.pnlUserImg.BackgroundImage = bmp;
                    mc.ShowDialog();
                }
            }
        }

        //    private void btnAtualizar_Click(object sender, EventArgs e)
        //    {
        //        if (!possuiCamposVazios())
        //        {
        //            try
        //            {
        //                --Abrindo a conexão
        //                if (conexao_SQL.State != ConnectionState.Open)
        //                    conexao_SQL.Open();

        //                --Inicializando um comando SELECT para ver se aquele nome já existe
        //                String select = "SELECT senha FROM tblCliente WHERE senha IN ('" + txtSenha.Text + "')";
        //                comando_SQL = new SqlCommand(select, conexao_SQL);
        //                SqlDataReader tem_senha = comando_SQL.ExecuteReader();

        //                --Lendo a resposta
        //                tem_senha.Read();

        //                --".HasRows" é uma propriedade que mostra se teve alguma resposta
        //                if (!tem_senha.HasRows)
        //                {
        //                    --Fechando o SELECT para poder reutilizar
        //                    tem_senha.Close();
        //                    if (validacao_email.IsMatch(txtEmail.Text))
        //                    {
        //                        try
        //                        {
        //                            String select_email = "SELECT email FROM tblCliente WHERE email IN ('" + txtEmail.Text + "')";
        //                            comando_SQL = new SqlCommand(select_email, conexao_SQL);
        //                            SqlDataReader email_existente = comando_SQL.ExecuteReader();

        //                            if (email_existente.HasRows)
        //                            {
        //                                if (txtSenha.Text.Equals(txtRepetirSenha.Text))
        //                                {
        //                                    this.Hide();
        //                                    FrmConfirmarEmail frm = new FrmConfirmarEmail("não_possui", txtSenha.Text, txtEmail.Text, "senha");

        //                                    frm.ShowDialog();

        //                                    if (FrmConfirmarEmail.atualizacao_SUCCESS)
        //                                        Close();
        //                                    else
        //                                    {
        //                                        this.Show();
        //                                        txtEmail.ResetText(); txtRepetirSenha.ResetText(); txtSenha.ResetText();
        //                                    }
        //                                }
        //                                else
        //                                {
        //                                    lblAviso.Text = "As senhas não são iguais";
        //                                    lblAviso.Visible = true;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                email_existente.Close();
        //                                lblAviso.Text = "Este email não existe";
        //                                lblAviso.Visible = true;
        //                            }
        //                        }
        //                        catch (Exception)
        //                        {

        //                        }
        //                    }
        //                    else
        //                    {
        //                        lblAviso.Text = "O email não é valido";
        //                        lblAviso.Visible = true;
        //                    }
        //                }
        //                else
        //                {
        //                    tem_senha.Close();
        //                    lblAviso.Text = "Não se repete a mesma senha que esqueceu";
        //                    lblAviso.Visible = true;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //                conexao_SQL.Close();
        //            }
        //        }
        //        else
        //        {
        //            lblAviso.Text = "Existem campos vazios";
        //            lblAviso.Visible = true;
        //        }
        //    }
        //    --Método que checa se o Form possui campos vazios
        //    private bool possuiCamposVazios()
        //    {
        //        bool b = false;
        //        foreach (Control controle in Controls)
        //        {
        //            if (controle is Bunifu.Framework.UI.BunifuMaterialTextbox)
        //            {
        //                if ((controle as Bunifu.Framework.UI.BunifuMaterialTextbox).Text.Equals(String.Empty))
        //                {
        //                    b = true;
        //                    break;
        //                }
        //            }
        //        }
        //        return b;
        //    }

        //    private void btnVoltar_Click(object sender, EventArgs e)
        //    {
        //        this.Close();
        //    }

        //    private void txtSenha_OnValueChanged(object sender, EventArgs e)
        //    {
        //        txtSenha.isPassword = true;
        //    }

        //    private void txtRepetirSenha_OnValueChanged(object sender, EventArgs e)
        //    {
        //        txtRepetirSenha.isPassword = true;
        //    }
    }
}
