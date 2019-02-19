using System;
using System.Collections.Generic;
using System.Drawing;

namespace AcroniBLL.FileInfo
{
    [Serializable]
    public class Collection
    {
        public List<Keyboard> Keyboards { get; set; } = new List<Keyboard>();
        public string CollectionName { get; set; }
        public Color CollectionColor { get; set; }
        /// <summary>
        /// Esse membro necessita que a classe Bitmap seja instanciada com os devidos parâmetros.
        /// </summary>
        public Bitmap CollectionPicture { get; set; }
        public int CollectionID { get; set; } = 0;
    }
}
