using System;
using System.Data.SqlClient;

namespace AcroniLibrary.SQL
{
    public class SQLMethods
    {
        public static bool SELECT_HASROWS(String commandSELECT)
        {
            using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao))
            {
                newConnection.Open();
                using (SqlCommand select = new SqlCommand(commandSELECT, newConnection))
                {
                    using (SqlDataReader hasName = select.ExecuteReader())
                    {
                        return hasName.HasRows;
                    }
                }
            }
        }
        public static int INSERT_INTO(String commandINSERT)
        {
            using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao))
            {
                newConnection.Open();
                using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                {
                    return insert.ExecuteNonQuery();
                }
            }
        }
        public static int INSERT_INTO(String commandINSERT,byte[] parameter)
        {
            using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao))
            {
                newConnection.Open();
                using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                {
                    insert.Parameters.AddWithValue("@image", parameter);
                    return insert.ExecuteNonQuery();
                }
            }
        }
    }
}
