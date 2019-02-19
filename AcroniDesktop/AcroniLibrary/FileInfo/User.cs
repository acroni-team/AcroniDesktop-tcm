using AcroniDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AcroniBLL.FileInfo
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
            using (FileStream savearchive = new FileStream($@"{Application.StartupPath}\..\..\{SQLConnection.nome_usuario}.acr", FileMode.OpenOrCreate))
            {
                BinaryFormatter objectToByteArray = new BinaryFormatter();
                objectToByteArray.Serialize(savearchive, Share.User);
            }
        }
        public void CatchFromFile()
        {
            using (FileStream savearchive = new FileStream($@"{Application.StartupPath}\..\..\{SQLConnection.nome_usuario}.acr", FileMode.Open))
            {
                BinaryFormatter objectToByteArray = new BinaryFormatter();
                Share.User = (User)objectToByteArray.Deserialize(savearchive);
                //UserName = (objectToByteArray.Deserialize(savearchive) as User).UserName;
                //isPremiumAccount = (objectToByteArray.Deserialize(savearchive) as User).isPremiumAccount;
                //KeyboardQuantity = (objectToByteArray.Deserialize(savearchive) as User).KeyboardQuantity;

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
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            this.ID = (int)sdr[0];
                        }
                    }
                }
            }
        }

    }
}
