using AcroniLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class User
    {
        public List<Collection> UserCollections { get; set; } = new List<Collection>();
        public string UserName { get; set; }
        public int ID { get; set; }
        public int KeyboardQuantity { get; set; } = 0;
        public bool isPremiumAccount { get; set; } = false;

        public void SendToFile()
        {
            using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + SQLConnection.nome_usuario + ".acr", FileMode.OpenOrCreate))
            {
                BinaryFormatter objectToByteArray = new BinaryFormatter();
                objectToByteArray.Serialize(savearchive, Share.User);
            }
        }
        public User()
        {
            using (SqlConnection cnn = new SqlConnection(SQLConnection.nome_conexao))
            {
                cnn.Open();
                using (SqlCommand select = new SqlCommand($"select id_cliente from tblCliente where usuario = '{SQLConnection.nome_usuario}'", cnn))
                {
                    using (SqlDataReader sdr = select.ExecuteReader())
                    {
                        sdr.Read();
                        ID = (int)sdr[0];
                    }
                }
            }
        }

    }
}
