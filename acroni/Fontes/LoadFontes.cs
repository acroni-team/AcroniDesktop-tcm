using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni.Fontes
{
    class LoadFontes
    {
        public static bool IsFontAddable { get; set; } = true;

        public LoadFontes(ref ComboBox cmbFonts, ref List<object> Fonte)
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    cmbFonts.Items.Add(fa.Name);
                    if (IsFontAddable)
                    {
                        Fonte.Add(fa.Name);
                    }
                }
                IsFontAddable = false;
            }
        }
    }
}
