using System;
using System.Collections.Generic;
using System.Drawing;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class Collection
    {
        public List<Keyboard> Keyboards { get; set; } = new List<Keyboard>();
        public string CollectionName { get; set; }
        public Color CollectionColor { get; set; }
    }
}
