using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AcroniBLL.CustomizingMethods.TextFonts
{
    public class LoadFontTypes
    {
        private bool IsFontAddable = true;

        ///<summary> 
        ///Esse método serve para obter todas as fontes que o usuário possui em seu computador em duas listas, 
        ///uma de fontefamily e outra de Fonts contendo cada estilo que a fonte possui.
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
            }
            IsFontAddable = false;
        }
    }
}
