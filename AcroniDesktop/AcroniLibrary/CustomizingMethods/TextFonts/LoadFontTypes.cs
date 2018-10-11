using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AcroniLibrary.CustomizingMethods.TextFonts
{
    public class LoadFontTypes
    {
        private bool IsFontAddable = true;

        ///<summary> 
        ///Esse método serve para obter todas as fontes que o usuário possui em seu computador em duas listas, uma de fontefamily e outra de Fonts contendo cada estilo que a fonte possui.
        ///</summary>

        // Antes o Braga tinha usado um using (InstalledFontCollection collection = new InstalledFontCollection()) dentro do Construtor.
        public LoadFontTypes(ref ComboBox cmbFonts, ref List<FontFamily> FontsFamily)
        {
            foreach (FontFamily fonte in FontFamily.Families)
            {
                cmbFonts.Items.Add(fonte.Name);
                if (IsFontAddable)
                {
                    FontsFamily.Add(fonte);
                }
                //Fonts.Add(new Font(fonte, 12f, FontStyle.Regular));
                //if(fonte.IsStyleAvailable(FontStyle.Bold))
                //    Fonts.Add(new Font(fonte, 12f, FontStyle.Bold));
                //if (fonte.IsStyleAvailable(FontStyle.Italic))
                //    Fonts.Add(new Font(fonte, 12f, FontStyle.Italic));
                //if (fonte.IsStyleAvailable(FontStyle.Underline))
                //    Fonts.Add(new Font(fonte, 12f, FontStyle.Underline));
                //if (fonte.IsStyleAvailable(FontStyle.Strikeout))
                //    Fonts.Add(new Font(fonte, 12f, FontStyle.Strikeout));
            }
            IsFontAddable = false;
        }
    }
}
