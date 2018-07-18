using System.Data.SqlClient;
using System.Data;
using System;

namespace acroni.Classes_internas
{
    class Conexao
    {
        internal static String nome_usuario { get; set; }
        SqlConnection conexao = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = ACRONI_SQL; User ID = Acroni; Password = acroni7");

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
