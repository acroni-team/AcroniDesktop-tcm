using System;
using System.Windows.Forms;
using static FormsDesign.FormDrag;
using System.Drawing;
//Eu não sei porque carlos meu VS não atualiza esse diretório: using acroni.Forms.Customizacao.Galeria;
using acroni.Forms.Seleção_do_teclado;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace acroni.Layout_Master
{
    public partial class LayoutMaster : Form
    {
        //private void isCustomizando
        //{

        //}

        #region Construtor
        public LayoutMaster()
        {
            InitializeComponent();
            trocar_nome_usuario(Classes_internas.Conexao.nome_usuario);
            trocar_imagem_usuario(selecionar_imagem_cliente());
            #region Atribuição de Dragging aos controles e no próprio form 

            ///<summary> 
            /// Esses métodos não foram gerados automaticamente. Trata-se duma maneira de permitir que não apenas o formulário seja arrastável, mas os controles também. 
            ///</summary>
            ///
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(Form_MouseDown);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(Form_MouseMove);
            }
            #endregion    
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

                }
                //--Fechando a resposta para poder usá-la novamente (NÃO ESQUECER!)
                resposta.Close();
                conexão_SQL.Close();
                return imagem_retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexão_SQL.Close();
                return null;
            }
        }

        #region Métodos de abrir formulários
        protected void btnAbrirGaleria_Click(object sender, EventArgs e)
        {
            Galeria.Galeria galeria = new Galeria.Galeria();
            galeria.Show();
        }

        private void btnAbrirSelecaoDeTeclado_Click(object sender, EventArgs e)
        {
            SelecionarTeclado selecionarTeclado = new SelecionarTeclado();
            selecionarTeclado.Show();
        }

        private void btnContinuarCustomizando_Click(object sender, EventArgs e)
        {

        }

        #endregion

        public void trocar_nome_usuario(String usuario) => lblNomeUsuario.Text = usuario;

        public void trocar_imagem_usuario(Image imagem) => fotoUsuario.Image = imagem;

        #region Métodos para transição de cores dos botões do menu
        private void bunifuImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(238, 63, 63);
        }

        private void bunifuImageButton2_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(166, 169, 173);
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(47, 47, 47);
        }

        #endregion

        #region Ações dos botões do menuStrip e transião de cores
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void ajudaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        #endregion
    }
}