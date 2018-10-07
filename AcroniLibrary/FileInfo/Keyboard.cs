using System;
using System.Collections.Generic;
using System.Drawing;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class Keyboard
    {
        public object BackgroundModeSize { get; set; }
        public List<Keycap> Keycaps { get; set; } = new List<Keycap>();
        public string Name { get; set; }
        public string ID { get; set; }
        public string Material { get; set; }
        public Image BackgroundImage { get; set; }
        public bool HasRestPads { get; set; }
        public string NickName { get; set; }
        public bool IsMechanicalKeyboard { get; set; }
    }
}
