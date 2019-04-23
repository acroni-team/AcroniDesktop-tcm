using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AcroniLibrary.SQL
{
    public class SQLMethods
    {
        public static bool SELECT_HASROWS(String commandSELECT)
        {
            try
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
            catch (Exception)
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS","")))
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
        }
        
        public static List<object> SELECT(string SelectCommand)
        {
            List<object> ret = new List<object> { };
            try {
                using (SqlConnection newConn = new SqlConnection(SQLConnection.nome_conexao))
                {
                    newConn.Open();
                    using (SqlCommand newComm = new SqlCommand((SelectCommand.Contains("SELECT") || SelectCommand.Contains("select")) ? SelectCommand : "SELECT " + SelectCommand, newConn))
                    {
                        using (SqlDataReader reader = newComm.ExecuteReader())
                        {
                            reader.Read();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                ret.Add(reader[i]);
                            }
                        }
                    }
                }
            } catch (Exception)
            {
                using (SqlConnection newConn = new SqlConnection(SQLConnection.nome_conexao.Replace("//SQLEXPRESS","")))
                {
                    newConn.Open();
                    using (SqlCommand newComm = new SqlCommand((SelectCommand.Contains("SELECT") || SelectCommand.Contains("select")) ? SelectCommand : "SELECT " + SelectCommand, newConn))
                    {
                        using (SqlDataReader reader = newComm.ExecuteReader())
                        {
                            reader.Read();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                ret.Add(reader[i]);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        public static int INSERT_INTO(String commandINSERT)
        {
            try
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao))
                {
                    newConnection.Open();
                    using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                    {
                        return insert.ExecuteNonQuery();
                    }
                }
            } catch (Exception)
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("//SQLEXPRESS","")))
                {
                    newConnection.Open();
                    using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                    {
                        return insert.ExecuteNonQuery();
                    }
                }
            }
        }
        
        public static int UPDATE(String commandUPDATE)
        {
            try
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao))
                {
                    newConnection.Open();
                    using (SqlCommand update = new SqlCommand(commandUPDATE, newConnection))
                    {
                        return update.ExecuteNonQuery();
                    }
                }
            } catch(Exception)
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("//SQLEXPRESS","")))
                {
                    newConnection.Open();
                    using (SqlCommand update = new SqlCommand(commandUPDATE, newConnection))
                    {
                        return update.ExecuteNonQuery();
                    }
                }
            }
        }

        public static int INSERT_INTO(String commandINSERT, byte[] parameter)
        {
            try
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
            } catch (Exception)
            {
                using (SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("//SQLEXPRESS","")))
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
}
