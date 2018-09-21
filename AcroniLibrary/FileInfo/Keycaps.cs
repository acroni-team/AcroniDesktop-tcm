using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcroniLibrary.FileInfo
{
    [Serializable]
    public class Keycaps
    {
        public string ID { get; set; }
        public System.Drawing.Color Color { get; set; }
        public System.Drawing.Image Switch { get; set; }
        public string Text { get; set; }
        public System.Drawing.Image Icon { get; set; }
        public System.Drawing.Font Font { get; set; }
        public object ContentAlignment { get; set; }
    }
}
