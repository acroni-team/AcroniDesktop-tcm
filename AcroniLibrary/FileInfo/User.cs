using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class User
    {
        public List<Colecao> userCollections { get; set; } = new List<Colecao>();
        public string nome { get; set; }
        public User()
        {
            nome = SQLConnection.nome_usuario;
        }
    }
}
