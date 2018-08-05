using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace acroni
{
    public partial class LayoutMasterComMenu : Layout_Master.LayoutMaster
    {
        public LayoutMasterComMenu()
        {
            InitializeComponent();
            trocar_nome_usuario($"{Classes_internas.Conexao.nome_usuario}!");
            trocar_imagem_usuario(selecionar_imagem_cliente());
        }

        #region Obter informações do cliente pelo banco
        public void trocar_nome_usuario(String usuario) => lblNomeUsuario.Text = usuario;

        public void trocar_imagem_usuario(Image imagem) => fotoUsuario.Image = imagem;

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
        #endregion

    }
}
