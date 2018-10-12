using AcroniLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class User
    {
        public List<Collection> UserCollections { get; set; } = new List<Collection>();
        public string UserName { get; set; }
        public int ID { get; set; }

        //public User()
        //{
        //    using (SqlConnection cnn = new SqlConnection(SQLConnection.nome_conexao))
        //    {
        //        cnn.Open();
        //        using (SqlCommand select = new SqlCommand($"select id_cliente from tblCliente where usuario = 'teste'", cnn))
        //        {
        //            using (SqlDataReader sdr = select.ExecuteReader())
        //            {
        //                sdr.Read();
        //                ID = (int)sdr[0];
        //            }
        //        }
        //    }
        //    UserName = SQLConnection.nome_usuario;
        //}

    }
}
