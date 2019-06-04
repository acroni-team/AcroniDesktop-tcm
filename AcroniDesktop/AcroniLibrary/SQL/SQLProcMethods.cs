using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AcroniLibrary.SQL
{
    public class SQLProcMethods
    {
        public static List<object> SELECT(string SelectCommand)
        {
            List<object> ret = new List<object> { };
            SqlConnection newConn = new SqlConnection(SQLConnection.nome_conexao);
            try
            {
                newConn.Open();
            }
            catch (Exception)
            {
                newConn.Close();
                newConn.Dispose();
                newConn = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS", ""));
                newConn.Open();
            }
            finally
            {
                using (SqlCommand newComm = new SqlCommand(SelectCommand, newConn))
                {
                    //newComm.CommandType = CommandType.StoredProcedure;
                    String[] parameters = SelectCommand.Split(new char[] {' ',','});
                    for (int i = 2; i < parameters.Length - 1; i+=2)
                    {
                        String[] eq = parameters[i].Split('=');
                        newComm.Parameters.AddWithValue("@"+eq[0],eq[1]);
                    }
                    using (SqlDataReader reader = newComm.ExecuteReader())
                    {   
                        reader.Read();
                        if (reader.HasRows)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            { ret.Add(reader[i]); }
                        }
                    }
                }
                newConn.Close();
                newConn.Dispose();
            }
            return ret;
        }

    }
}
