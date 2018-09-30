using System.Data.SqlClient;
using System.Data;
using System;
using System.Drawing;

namespace AcroniLibrary
{
    public class SQLConnection
    {
        public static String nome_usuario { get; set; }
        public static SqlConnection conexao = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");
        public static String nome_conexao = "Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7";
        public static Image imagem_cliente;
        public void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.OpenAsync();
            }
            else
            {
                throw new Exception("A conexão com o banco já está aberta");
            }
        }
        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            else
            {
                throw new Exception("A conexão com o banco já está fechada");
            }
        }
    }
}
