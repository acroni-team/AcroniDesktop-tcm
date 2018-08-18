using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AcroniLibrary.CustomizingMethods.TextFonts
{
    public class LoadFonts
    {
        public static bool IsFontAddable = true;

        ///<summary> 
        ///Esse método serve para obter todas as fontes que o usuário possui em seu computador.
        ///</summary>
        public LoadFonts(ref ComboBox cmbFonts, ref List<FontFamily> Fontes)
        {
            using (InstalledFontCollection collection = new InstalledFontCollection())
            {
                foreach (FontFamily fonte in collection.Families)
                {
                    cmbFonts.Items.Add(fonte.Name);
                    if (IsFontAddable)
                    {
                        Fontes.Add(fonte);
                    }
                }
                IsFontAddable = false;
            }
        }
    }
}
