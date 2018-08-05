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
    class CarregarFontes
    {
        public static bool IsFontAddable { get; set; } = true;

        ///<summary> 
        ///Esse método serve para obter todas as fontes que o usuário possui em seu computador.
        ///</summary>
        public CarregarFontes(ref ComboBox cmbFonts, ref List<object> Fontes)
        {
            using (InstalledFontCollection collection = new InstalledFontCollection())
            {
                foreach (FontFamily fontFamily in collection.Families)
                {
                    cmbFonts.Items.Add(fontFamily.Name);
                    if (IsFontAddable)
                    {
                        Fontes.Add(fontFamily);
                    }
                }
                IsFontAddable = false;
            }
        }
    }
}
