using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcroniLibrary;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Text;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using AcroniControls;
using AcroniLibrary.SQL;

namespace AcroniUI
{
    public partial class TemplateMenu : Template
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(TemplateMenu));
        int contTeclados = 0;
        public TemplateMenu()
        {
            InitializeComponent();
            //using (PrivateFontCollection fontesLayout = new PrivateFontCollection())
            //{
            //    fontesLayout.AddFontFile(Application.StartupPath + @"\Fontes\Qanelas-ExtraBold.ttf");
            //    lblAcroni.Font = new Font(fontesLayout.Families[0], 16);

            //}
            //using (PrivateFontCollection fontesLayout = new PrivateFontCollection())
            //{
            //    fontesLayout.AddFontFile(Application.StartupPath + @"\Fontes\OpenSans-Regular.ttf");
            //    arquivoToolStripMenuItem.Font = new Font(fontesLayout.Families[0], 12, FontStyle.Regular);
            //    ajudaToolStripMenuItem.Font = new Font(fontesLayout.Families[0], 12, FontStyle.Regular);
            //    lblPlanoUsu.Font = new Font(fontesLayout.Families[0], 9, FontStyle.Regular);
            //    lblQtdDisponivel.Font = new Font(fontesLayout.Families[0], (float)8.25, FontStyle.Regular);
            //    lblQtdDisponivel.Font = new Font(fontesLayout.Families[0], (float)8.25, FontStyle.Regular);

            //}
            //using (PrivateFontCollection fontesLayout = new PrivateFontCollection())
            //{
            //    fontesLayout.AddFontFile(Application.StartupPath + @"\Fontes\OpenSans-SemiBold.ttf");
            //    lblNomeUsu.Font = new Font(fontesLayout.Families[0], 12);
            //    foreach (Control menuItem in this.pnlOptions.Controls)
            //    {
            //        menuItem.Font = new Font(fontesLayout.Families[0], 13, FontStyle.Regular);
            //    }
            //}

            Bunifu.Framework.UI.BunifuElipse ellipse = new Bunifu.Framework.UI.BunifuElipse();
            foreach (Control c in pnlOptions.Controls)
            {
                ellipse.ApplyElipse(c, 7);
            }


            string[] arquivos = Directory.GetFiles(@"C:\Users\Public\Pictures");
            if (arquivos.Length > 0)
            {
                if (arquivos.Length == 1)
                {
                    pnlPreenchido1.Visible = true;
                    contTeclados++;
                    if (arquivos.Length == 2)
                    {
                        pnlPreenchido2.Visible = true;
                        contTeclados++;
                        if (arquivos.Length == 3)
                        {
                            pnlPreenchido3.Visible = true;
                            contTeclados++;
                            if (arquivos.Length == 4)
                            {
                                pnlPreenchido4.Visible = true;
                                contTeclados++;
                                if (arquivos.Length == 5)
                                {
                                    pnlPreenchido5.Visible = true;
                                    contTeclados++;
                                }
                            }
                        }
                    }

                }
            }
            ImgUsu.SizeMode = PictureBoxSizeMode.Zoom;
            lblQtdGasta.Text = Convert.ToString(contTeclados);
            trocar_nome_usuario($"{SQLConnection.nome_usuario}");
            trocar_imagem_usuario(selecionar_imagem_cliente());
            //Compartilha.nomeUsu = lblNomeUsu.Text;
            //trocar_plano_usuario($"{Conexao.plano_usuario}!");
            #region Verificar conectividade com internet

            #endregion
        }
        #region Obter informações do cliente pelo banco
        public void trocar_nome_usuario(String usuario) => lblNomeUsu.Text = SQLConnection.nome_usuario;
        //public void trocar_plano_usuario(String plano) => lblPlanoUsu.Text += plano;

        public void trocar_imagem_usuario(Image imagem) => ImgUsu.Image = imagem;
        SqlConnection conexão_SQL = new SqlConnection(SQLConnection.nome_conexao);
        SqlCommand comando_SQL;

        public Image selecionar_imagem_cliente()
        {
            try
            {
                //--Checando se a conexão está aberta e a abrindo
                if (conexão_SQL.State != ConnectionState.Open)
                    conexão_SQL.Open();

                //--Criando o comando SELECT e seleciando no SQL
                String select = "SELECT imagem_cliente FROM tblCliente WHERE usuario IN ('" + SQLConnection.nome_usuario + "')";
                comando_SQL = new SqlCommand(select, conexão_SQL);
                SqlDataReader resposta = comando_SQL.ExecuteReader();
                Image imagem_retorno = (Image)resources.GetObject("ImgUsu.Image");
                //--Checando se tem respostas do SELECT
                if (resposta.HasRows)
                {
                    resposta.Read();
                    //--Convertendo a variável que está no banco em imagem
                    byte[] img = (byte[])(resposta[0]);

                    if (img != null)
                    {
                        MemoryStream leitor_memoria = new MemoryStream(img);
                        imagem_retorno = Image.FromStream(leitor_memoria);
                    }

                }
                //--Fechando a resposta para poder usá-la novamente (NÃO ESQUECER!)
                resposta.Close();
                conexão_SQL.Close();
                return imagem_retorno;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                conexão_SQL.Close();

                return (Image)resources.GetObject("ImgUsu.Image");
            }
        }


        #endregion
        private void CursorHand(object sender, EventArgs e)
        {
            Control Hand = (Control)sender;
            Hand.Cursor = Cursors.Hand;
        }

        private void pnlAreaUsu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImgUsu_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath ellipse = new GraphicsPath())
            {
                Rectangle imgUsu = ImgUsu.ClientRectangle;
                ellipse.AddEllipse(0, 0, imgUsu.Width, imgUsu.Height);
                ImgUsu.Region = new Region(ellipse);
            }
            using (GraphicsPath ellipse = new GraphicsPath())
            {
                Rectangle btnConfig = this.btnConfig.ClientRectangle;

                ellipse.AddEllipse(0, 0, btnConfig.Width, btnConfig.Height);

                this.btnConfig.Region = new Region(ellipse);

            }

        }
        private void btnAbrirGaleria_Click(object sender, EventArgs e)
        {
            Galeria galeria = new Galeria(false);
            galeria.Show();
            fechaForms();
        }
        private void fechaForms()
        {
            for(int i = 0; i < Application.OpenForms.Count; i++)
            {
                if(!Application.OpenForms[i].Name.Equals("FrmLogin"))
                    Application.OpenForms[i].Close();
            }
        }

        private void btnSelectKeyboard_Click(object sender, EventArgs e)
        {
            SelectKeyboard selectKeyboard = new SelectKeyboard();
            selectKeyboard.Show();
            fechaForms();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            AcroniMessageBoxConfirm confirmExit =  new AcroniControls.AcroniMessageBoxConfirm("Saindo daqui", "Deseja realmente deslogar?", "OK");
            confirmExit.ShowDialog();
            if (confirmExit.ButtonClicked == AcceptButtons.OK)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is AcroniUI.LoginAndSignUp.FrmLogin)
                    {
                        (form as LoginAndSignUp.FrmLogin).CleanAllTextbox();
                        form.Show();
                        break;
                    }
                    else
                    {
                        LoginAndSignUp.FrmLogin login = new AcroniUI.LoginAndSignUp.FrmLogin();
                        login.CleanAllTextbox();
                        login.Show();
                    }
                }
                this.Close();
            }            
        }
    }
}