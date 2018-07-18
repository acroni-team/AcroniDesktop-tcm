using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;

namespace acroni.Cadastro
{
    public partial class FrmConfirmarEmail : Form
    {

        private String email_public, senha_public, usuario_public, tipo_public;
        public FrmConfirmarEmail(String usuario, String senha, String email, String tipo)
        {
            InitializeComponent();
            //--Gerando os números para se colocar nos botões
            Random numero = new Random();
            int[] numeros = new int[3];
            numeros[0] = numero.Next(1, 100);
            for (int i = 1; i < 3; i++)
            {
                int n = numero.Next(1,100);
                while (n == numeros[i - 1])
                    n = numero.Next(1, 100);
                numeros[i] = n;
            }
            btnOption1.Text = numeros[0].ToString();
            btnOption2.Text = numeros[1].ToString();
            btnOption3.Text = numeros[2].ToString();

            //--Escolhendo um número aleatório para ser o certo
            numero_certo = numeros[numero.Next(3)];

            //--Retiranado as variaveis do construtor (já validadas)
            usuario_public = usuario;
            senha_public = senha;
            email_public = email;
            tipo_public = tipo;

            //--Enviando o numero para o email da pessoa
            object c = null; EventArgs e = null;
            btnReenviar_Click(c, e);
        }
        int numero_certo;
        public static bool atualizacao_SUCCESS;
        private void buttonClicked(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if (b.Text.Equals(numero_certo.ToString()))
            {
                MessageBox.Show("Cadastro concluido");
                atualizacao_SUCCESS = true;
                this.Close();
                MessageBox.Show(atualizacao_SUCCESS.ToString());
                if (tipo_public.Equals("cadastro"))
                    insert();
                else if (tipo_public.Equals("senha"))
                    update();
            }else
            {
                MessageBox.Show("Cadastro cancelado");
                atualizacao_SUCCESS = false;
                this.Close();
            }
        }
        
        private void btnReenviar_Click(object sender, EventArgs e)
        {
            //--Lembrem-se disso como se fosse Excel -> Se () ? então se VERDADEIRO : se FALSO 
            String titulo = (tipo_public.Equals("cadastro")?"Fazendo o seu cadastro":(tipo_public.Equals("senha")?"Atualização de senha":"--Unknown--"));
            String mensagem = "Olá " + usuario_public + ". O número certo é " + numero_certo;
            try
            {
                MailMessage objeto_mail = new MailMessage("acroni.acroni7@gmail.com", email_public, titulo, mensagem);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("acroni.acroni7@gmail.com", "acroni77");
                client.EnableSsl = true;
                client.Send(objeto_mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O email não existe");
                Application.Exit();
            }

        }

        //--Inicializando uma conexão e um COMANDO
        SqlConnection conexao_SQL = new SqlConnection(Colorpicker.ColorpickerHandlers.nome_conexao);
        SqlCommand comando_SQL;

        private void update()
        {
            try
            {
                //--Abrindo a conexão
                if (conexao_SQL.State != ConnectionState.Open)
                    conexao_SQL.Open();

                //--Inicializando um comando UPDATE e execuntando
                String update = "UPDATE tblCliente SET usuario = '" + usuario_public + "',senha = '" + senha_public + "' WHERE email = '" + email_public + "'";
                comando_SQL = new SqlCommand(update, conexao_SQL);
                //--Para executar, utilizo ExecuteNonQuery(), pois ele retorna apenas o numero de linhas afetadas
                int n_linhas_afetadas = comando_SQL.ExecuteNonQuery();

                //--Fechando a conexão (NÃO ESQUECER!)
                conexao_SQL.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao_SQL.Close();
            }

        }

        private void insert()
        {
            try
            {
                //--Abrindo a conexão
                if (conexao_SQL.State != ConnectionState.Open)
                    conexao_SQL.Open();

                //--Inicializando um comando INSERT e execuntando
                String insert = "INSERT INTO tblCliente VALUES ('" + usuario_public + "','" + senha_public + "','" + email_public + "')";
                comando_SQL = new SqlCommand(insert, conexao_SQL);
                //--Para executar, utilizo ExecuteNonQuery(), pois ele retorna apenas o numero de linhas afetadas
                int n_linhas_afetadas = comando_SQL.ExecuteNonQuery();
                //--Fechando a conexão (NÃO ESQUECER!)
                conexao_SQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao_SQL.Close();
            }
        }
    }
}
