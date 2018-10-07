using AcroniLibrary.SQL;
using System;
using System.Collections.Generic;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class User
    {
        public List<Collection> UserCollections { get; set; } = new List<Collection>();
        public string UserName { get; set; }
        public User()
        {
            UserName = SQLConnection.nome_usuario;
        }
    }
}
