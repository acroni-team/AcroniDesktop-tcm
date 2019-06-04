using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AcroniLibrary.SQL
{
    public class SQLMethods
    {
        public static bool SELECT_HASROWS(String commandSELECT)
        {
            bool HR = false;
            SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao);
            try
            {
                newConnection.Open();
            }
            catch (Exception)
            {
                newConnection.Close();
                newConnection.Dispose();
                newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS", ""));
                newConnection.Open();
            }finally
            {
                using (SqlCommand select = new SqlCommand(commandSELECT, newConnection))
                {
                    using (SqlDataReader hasRows = select.ExecuteReader())
                    {
                        HR = hasRows.HasRows;
                    }
                }
                newConnection.Close();
                newConnection.Dispose();
            }
            return HR;
        }
        
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
                newConn.Close();
                newConn.Dispose();
            }
            return ret;
        }

        public static int INSERT_INTO(String commandINSERT)
        {
            int rowsAffected = 0;
            SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao);
            try
            {
                newConnection.Open();               
            } catch (Exception)
            {
                newConnection.Close();
                newConnection.Dispose();
                newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS", ""));
                newConnection.Open();
            }finally
            {
                using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                {
                    rowsAffected = insert.ExecuteNonQuery();
                }
                newConnection.Close();
                newConnection.Dispose();
            }
            return rowsAffected;
        }
        
        public static int UPDATE(String commandUPDATE)
        {
            int rowsAffected = 0;
            SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao);
            try
            {
                newConnection.Open();
            } catch(Exception)
            {
                newConnection.Close();
                newConnection.Dispose();
                newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS", ""));
                newConnection.Open();
            }finally
            {
                using (SqlCommand update = new SqlCommand(commandUPDATE, newConnection))
                {
                    rowsAffected = update.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public static int INSERT_INTO(String commandINSERT, byte[] parameter)
        {
            int rowsAffected = 0;
            SqlConnection newConnection = new SqlConnection(SQLConnection.nome_conexao);
            try
            {   
                newConnection.Open();
            } catch (Exception)
            {
                newConnection.Close();
                newConnection.Dispose();
                newConnection = new SqlConnection(SQLConnection.nome_conexao.Replace("\\SQLEXPRESS", ""));
                newConnection.Open();
            }finally
            {
                using (SqlCommand insert = new SqlCommand(commandINSERT, newConnection))
                {
                    insert.Parameters.AddWithValue("@image", parameter);
                    rowsAffected = insert.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}