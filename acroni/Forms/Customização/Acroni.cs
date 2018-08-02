using System;
using System.Windows.Forms;
using acroni.Colorpicker;
using acroni.Layout_Master;
using acroni.Login;
using acroni.Fontes;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
namespace acroni
{
    public partial class Acroni : LayoutMaster
    {
        /// <summary>
        /// Construtor que carrega o login. 
        /// </summary>

            //public void initialize_Splash()
            //{
            //Application.Run(new SplashEscrita());
            //}

        public Acroni()
        {
            //Thread t_splash = new Thread(new ThreadStart(initialize_Splash));
            //t_splash.Start();
            FrmLogin frmLogin = new FrmLogin();
            InitializeComponent();
            //t_splash.Abort();
            frmLogin.ShowDialog();
            trocar_nome_usuario(Classes_internas.Conexao.nome_usuario);
            trocar_imagem_usuario(selecionar_imagem_cliente());
        }

        #region Métodos do colorpicker
        /// <summary>
        /// Essa parte do programa está destinada ao funcionamento do colorpicker.
        /// </summary>

            /// <summary>
            // Método que pega a cor selecionada de um botão e atualiza o histórico de cores
            /// </summary>
        private void btnColorChosen_Click(object sender, EventArgs e)
        {
            new SetColorpickerVisibility(ref pnlColorpicker, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
        }

    
        private void btnGetSelctedColor(object sender, EventArgs e)
        {
            Button btnCol = (Button)sender;
            new SetHistColors(ref pnlColorpicker, ref btnCol, ref btnColorChosen, ref btnHist1, ref btnHist2, ref btnHist3, ref pnlHistorico);
            lblCorRGB.Text = String.Format("R: {0}, G: {1}, B: {2} ", SetHistColors.GetColor.R, SetHistColors.GetColor.G, SetHistColors.GetColor.B);
            if (SetHistColors.GetColor.IsKnownColor)
            {
                lblKnownColorName.Visible = true;
                lblKnownColorName.Text = String.Format("Outro nome: {0}", SetHistColors.GetColor.Name);
            }
            else
                lblKnownColorName.Visible = false;
        }

        #endregion

        #region Fontes das teclas
        /// <summary>
        // Essa parte do programa é destinada para o funcionamento das fontes personalizadas.
        /// </summary>
        List<object> Fonte = new List<object>();

        private void Acroni_Load(object sender, EventArgs e)
        {
            LoadFontes a = new LoadFontes(ref cmbFonts, ref Fonte);
        }

        private void txtSelectFont_TextChanged(object sender, EventArgs e)
        {
            Regex a = new Regex(txtSelectFont.Text, RegexOptions.IgnoreCase);
            foreach (string c in Fonte)
            {
                cmbFonts.Items.Remove(c);
            }
            Acroni_Load(sender, e);
            if (txtSelectFont.Text != "")
            {
                foreach (string c in Fonte)
                {
                    if (!(a.IsMatch(c)))
                    {
                        cmbFonts.Items.Remove(c);
                    }
                }
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Font = new System.Drawing.Font(cmbFonts.Text, 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion 

        SqlConnection conexão_SQL = new SqlConnection(Classes_internas.Conexao.nome_conexao);
        SqlCommand comando_SQL;

        public Image selecionar_imagem_cliente()
        {
            try
            {
                //--Checando se a conexão está aberta e a abrindo
                if (conexão_SQL.State != ConnectionState.Open)
                    conexão_SQL.Open();

                //--Criando o comando SELECT e seleciando no SQL
                String select = "SELECT imagem FROM tblCliente WHERE usuario IN ('" + Classes_internas.Conexao.nome_usuario + "')";

                comando_SQL = new SqlCommand(select, conexão_SQL);
                SqlDataReader resposta = comando_SQL.ExecuteReader();
                Image imagem_retorno = null;
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

                    //--Fechando a resposta para poder usá-la novamente (NÃO ESQUECER!)
                    resposta.Close();
                    conexão_SQL.Close();
                }
                return imagem_retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexão_SQL.Close();
                return null;
            }
        }
    }
}