using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class Colecao
    {
        public List<Teclado> collection { get; set; } = new List<Teclado>();
        public string collectionNome { get; set; }
        public System.Drawing.Color backColor { get; set; }
    }
}
