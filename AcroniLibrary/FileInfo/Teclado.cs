using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class Teclado
    {
        public object BackgroundModeSize { get; set; }
        public List<Keycaps> Keycaps { get; set; } = new List<FileInfo.Keycaps>();
        public string Name { get; set; }
        public string ID { get; set; }
        public string Material { get; set; }
        public System.Drawing.Image BackgroundImage { get; set; }
        public bool hasRestPads { get; set; }
        public string NickName { get; set; }
        public bool isMechanicalKeyboard { get; set; }
        public string tipoTeclado;
    }
}
